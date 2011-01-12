﻿//--------------------------------------------------------------------------------------------------------------------------
// <copyright file="Repository.cs" company="Oscar Brouwer">
//     Copyright (c) Oscar Brouwer 2010. All rights reserved.
// </copyright>
// <summary>
//     Holds the generic functionality of a repository.
// </summary>
//--------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Microsoft.Practices.EnterpriseLibrary.Validation;

using OscarBrouwer.Framework.Validation;

namespace OscarBrouwer.Framework.Entities {
  /// <summary>This abstract class defines the API of a repository that is capable of accessing specific types in a 
  /// persistency.</summary>
  /// <typeparam name="T">The type of entity that is managed by the repository.</typeparam>
  public abstract class Repository<T> : ISpecificationVisitor<T>, IDisposable where T : class {
    #region Constructor
    /// <summary>Initializes a new instance of the <see cref="Repository{T}"/> class.</summary>
    protected Repository() {
      /* Set a default validator */
      this.Validator = new EntityValidator<T>();
    }
    #endregion

    #region Properties
    /// <summary>Gets or sets the instance that must be used to validate the entities before adding or updating them in
    /// the repository.</summary>
    public EntityValidator<T> Validator { get; set; }
    #endregion

    #region ISpecificationVisitor implementation
    /// <summary>Creates an AND-expression using the two specified specifications.</summary>
    /// <param name="leftOperand">The left operand of the combination.</param>
    /// <param name="rightOperand">The right operand of the combination.</param>
    /// <returns>The created expression.</returns>
    Func<T, bool> ISpecificationVisitor<T>.CreateAndExpression(ISpecification<T> leftOperand, ISpecification<T> rightOperand) {
      return this.CreateAndExpressionCore(leftOperand, rightOperand);
    }

    /// <summary>Creates an OR-expression using the two specified specifications.</summary>
    /// <param name="leftOperand">The left operand of the combination.</param>
    /// <param name="rightOperand">The right operand of the combination.</param>
    /// <returns>The created expression.</returns>
    Func<T, bool> ISpecificationVisitor<T>.CreateOrExpression(ISpecification<T> leftOperand, ISpecification<T> rightOperand) {
      return this.CreateOrExpressionCore(leftOperand, rightOperand);
    }

    /// <summary>Creates a lambda-expression using the specified expression. Typically, this method simply returns the 
    /// parameter.</summary>
    /// <param name="expression">The expression that was originally passed to the specification.</param>
    /// <returns>The created expression.</returns>
    Func<T, bool> ISpecificationVisitor<T>.CreateLambdaExpression(Func<T, bool> expression) {
      return this.CreateLambdaExpressionCore(expression);
    }

    /// <summary>Creates a LIKE-expression using the specified field and searchpattern.</summary>
    /// <param name="field">The field of type <c>T</c> that must match the pattern.</param>
    /// <param name="pattern">The pattern to which the field must apply. The pattern may contain a '*' and '?' wildcard.
    /// </param>
    /// <returns>The created expression.</returns>
    Func<T, bool> ISpecificationVisitor<T>.CreateLikeExpression(Func<T, string> field, string pattern) {
      return this.CreateLikeExpressionCore(field, pattern);
    }

    /// <summary>Creates a lambda-expression using the custom specification. This method is executed when a 
    /// specification-type is used that is not part of the default specification system.</summary>
    /// <param name="specification">The custom specification.</param>
    /// <returns>The created expression.</returns>
    Func<T, bool> ISpecificationVisitor<T>.CreateCustomExpression(ISpecification<T> specification) {
      return this.CreateCustomExpressionCore(specification);
    }
    #endregion

    #region CRUD methods
    /// <summary>Saves all the changes to the underlying persistency.</summary>
    public void SaveChanges() {
      this.SaveChanges(null);
    }

    /// <summary>Saves all the changes to the underlying persistency.</summary>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    public void SaveChanges(DataSourceInfo dataSourceInfo) {
      this.SaveChangesCore(dataSourceInfo);
    }

    /// <summary>Creates a new entity. To add the entity to the repository, use the <see cref="M:AddEntity(T)"/> 
    /// method with the returned value.</summary>
    /// <returns>The newly created entity.</returns>
    public T CreateEntity() {
      return this.CreateEntity(null);
    }

    /// <summary>Creates a new entity. To add the entity to the repository, use the <see cref="M:AddEntity(T)"/> 
    /// method with the returned value.</summary>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <returns>The newly created entity.</returns>
    public T CreateEntity(DataSourceInfo dataSourceInfo) {
      return this.CreateEntityCore(dataSourceInfo);
    }

    /// <summary>Adds a new entity to the repository. Call <see cref="M:SaveChanges()"/> to make the addition
    /// permanent.</summary>
    /// <param name="entity">The entity that must be added to the repository.</param>
    /// <exception cref="ArgumentNullException">If <paramref name="entity"/> is <see langword="null"/>.</exception>
    /// <returns>The entity with the most recent values.</returns>
    public T AddEntity(T entity) {
      return this.AddEntity(entity, null);
    }

    /// <summary>Adds a new entity to the repository. Call <see cref="M:SaveChanges()"/> to make the addition
    /// permanent.</summary>
    /// <param name="entity">The entity that must be added to the repository.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <exception cref="ArgumentNullException">If <paramref name="entity"/> is <see langword="null"/>.</exception>
    /// <returns>The entity with the most recent values.</returns>
    public T AddEntity(T entity, DataSourceInfo dataSourceInfo) {
      if(entity == null) {
        throw new ArgumentNullException("entity");
      }

      if(this.Validator != null) {
        ValidationResults results = this.Validator.PerformDeepValidation(entity);
        if(!results.IsValid) {
          throw new ValidationException("The entity is not valid and will not be added to the repository", results);
        }
      }

      return this.AddEntityCore(entity, dataSourceInfo);
    }

    /// <summary>Updates the repository with the changes made to the entity. Call <see cref="M:SaveChanges()"/> to make
    /// the changes permanent.</summary>
    /// <param name="entity">The entity whose members are updated.</param>
    /// <exception cref="ArgumentNullException">If <paramref name="entity"/> is <see langword="null"/>.</exception>
    /// <returns>The entity with the most recent values.</returns>
    public T UpdateEntity(T entity) {
      return this.UpdateEntity(entity, null);
    }

    /// <summary>Updates the repository with the changes made to the entity. Call <see cref="M:SaveChanges()"/> to make
    /// the changes permanent.</summary>
    /// <param name="entity">The entity whose members are updated.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <exception cref="ArgumentNullException">If <paramref name="entity"/> is <see langword="null"/>.</exception>
    /// <returns>The entity with the most recent values.</returns>
    public T UpdateEntity(T entity, DataSourceInfo dataSourceInfo) {
      if(entity == null) {
        throw new ArgumentNullException("entity");
      }

      if(this.Validator != null) {
        ValidationResults results = this.Validator.PerformDeepValidation(entity);
        if(!results.IsValid) {
          throw new ValidationException("The entity is not valid and will not be added to the repository", results);
        }
      }

      return this.UpdateEntityCore(entity, dataSourceInfo);
    }

    /// <summary>Deletes the entity from the repository. Call <see cref="M:SaveChanges()"/> to make the changes 
    /// permanent.</summary>
    /// <param name="entity">The entity that must be deleted.</param>
    /// <exception cref="ArgumentNullException">If <paramref name="entity"/> is <see langword="null"/>.</exception>
    public void DeleteEntity(T entity) {
      this.DeleteEntity(entity, null);
    }

    /// <summary>Deletes the entity from the repository. Call <see cref="M:SaveChanges()"/> to make the changes 
    /// permanent.</summary>
    /// <param name="entity">The entity that must be deleted.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <exception cref="ArgumentNullException">If <paramref name="entity"/> is <see langword="null"/>.</exception>
    public void DeleteEntity(T entity, DataSourceInfo dataSourceInfo) {
      if(entity == null) {
        throw new ArgumentNullException("entity");
      }

      this.DeleteEntityCore(entity, dataSourceInfo);
    }
    #endregion

    #region Select methods
    /// <summary>Finds all the entities of type <typeparamref name="T"/>.</summary>
    /// <returns>All the available entities.</returns>
    public IEnumerable<T> FindAll() {
      return this.FindAll((DataSourceInfo)null);
    }

    /// <summary>Finds all the entities of type <typeparamref name="T"/>.</summary>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <returns>All the available entities.</returns>
    public IEnumerable<T> FindAll(DataSourceInfo dataSourceInfo) {
      return this.FindAllCore(dataSourceInfo);
    }

    /// <summary>Finds all the available entities that match the specification.</summary>
    /// <param name="specification">The specification to which entities must match.</param>
    /// <returns>The entities that match the specification.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="specification"/> is <see langword="null"/>.</exception>
    public IEnumerable<T> FindAll(ISpecification<T> specification) {
      return this.FindAll(specification, null);
    }

    /// <summary>Finds all the available entities that match the specification.</summary>
    /// <param name="specification">The specification to which the entities must match.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <returns>The entities that match the specification.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="specification"/> is <see langword="null"/>.</exception>
    public IEnumerable<T> FindAll(ISpecification<T> specification, DataSourceInfo dataSourceInfo) {
      if(specification == null) {
        throw new ArgumentNullException("specification");
      }

      Func<T, bool> expression = specification.Visit(this);
      return this.FindAllCore(expression, dataSourceInfo);
    }

    /// <summary>Finds a single entity that matches the specification.</summary>
    /// <param name="specification">The specification to which the entity must match.</param>
    /// <returns>The found entity.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="specification"/> is <see langword="null"/>.</exception>
    public T FindSingle(ISpecification<T> specification) {
      return this.FindSingle(specification, (DataSourceInfo)null);
    }

    /// <summary>Finds a single entity that matches the specification.</summary>
    /// <param name="specification">The specification to which the entity must match.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <returns>The found entity.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="specification"/> is <see langword="null"/>.</exception>
    public T FindSingle(ISpecification<T> specification, DataSourceInfo dataSourceInfo) {
      if(specification == null) {
        throw new ArgumentNullException("specification");
      }

      Func<T, bool> expression = specification.Visit(this);
      return this.FindSingleCore(expression, dataSourceInfo);
    }

    /// <summary>Finds a single entity that matches the specification. If no result was found, the specified default-value
    /// is returned.</summary>
    /// <param name="specification">The specification to which the entity must match.</param>
    /// <param name="defaultValue">The value that will be returned when no match was found.</param>
    /// <returns>The found entity or <paramref name="defaultValue"/> if there was no result.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="specification"/> is <see langword="null"/>.</exception>
    public T FindSingle(ISpecification<T> specification, T defaultValue) {
      return this.FindSingle(specification, defaultValue, null);
    }

    /// <summary>Finds a single entity that matches the specification. If no result was found, the specified default-value
    /// is returned.</summary>
    /// <param name="specification">The specification to which the entity must match.</param>
    /// <param name="defaultValue">The value that will be returned when no match was found.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <returns>The found entity or <paramref name="defaultValue"/> if there was no result.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="specification"/> is <see langword="null"/>.</exception>
    public T FindSingle(ISpecification<T> specification, T defaultValue, DataSourceInfo dataSourceInfo) {
      if(specification == null) {
        throw new ArgumentNullException("specification");
      }

      Func<T, bool> expression = specification.Visit(this);
      return this.FindSingleCore(expression, dataSourceInfo, defaultValue);
    }

    /// <summary>Finds the first entity that matches the specification.</summary>
    /// <param name="specification">The specification to which the entity must match.</param>
    /// <returns>The found entity.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="specification"/> is <see langword="null"/>.</exception>
    public T FindFirst(ISpecification<T> specification) {
      return this.FindFirst(specification, (DataSourceInfo)null);
    }

    /// <summary>Finds the first entity that matches the specification.</summary>
    /// <param name="specification">The specification to which the entity must match.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <returns>The found entity.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="specification"/> is <see langword="null"/>.</exception>
    public T FindFirst(ISpecification<T> specification, DataSourceInfo dataSourceInfo) {
      if(specification == null) {
        throw new ArgumentNullException("specification");
      }

      Func<T, bool> expression = specification.Visit(this);
      return this.FindFirstCore(expression, dataSourceInfo);
    }

    /// <summary>Finds the first entity that matches the specification. If no result was found, the specified default-value
    /// is returned.</summary>
    /// <param name="specification">The specification to which the entity must match.</param>
    /// <param name="defaultValue">The value that will be returned when no match was found.</param>
    /// <returns>The found entity or <paramref name="defaultValue"/> if there was no result.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="specification"/> is <see langword="null"/>.</exception>
    public T FindFirst(ISpecification<T> specification, T defaultValue) {
      return this.FindFirst(specification, defaultValue, null);
    }

    /// <summary>Finds the first entity that matches the specification. If no result was found, the specified default-value
    /// is returned.</summary>
    /// <param name="specification">The specification to which the entity must match.</param>
    /// <param name="defaultValue">The value that will be returned when no match was found.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <returns>The found entity or <paramref name="defaultValue"/> if there was no result.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="specification"/> is <see langword="null"/>.</exception>
    public T FindFirst(ISpecification<T> specification, T defaultValue, DataSourceInfo dataSourceInfo) {
      if(specification == null) {
        throw new ArgumentNullException("specification");
      }

      Func<T, bool> expression = specification.Visit(this);
      return this.FindFirstCore(expression, dataSourceInfo, defaultValue);
    }
    #endregion

    #region Dispose methods
    /// <summary>Disposes any resources held by this instance.</summary>
    public void Dispose() {
      this.DisposeManagedResources();
    }

    /// <summary>Disposes all the managed resources that are held by this instance.</summary>
    protected virtual void DisposeManagedResources() {
      /* By default there is nothing to dispose */
    }
    #endregion

    #region Extensibility methods
    /// <summary>Saves all the changes to the underlying persistency.</summary>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    protected abstract void SaveChangesCore(DataSourceInfo dataSourceInfo);

    /// <summary>Creates a new entity.</summary>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <returns>The newly created entity.</returns>
    protected abstract T CreateEntityCore(DataSourceInfo dataSourceInfo);

    /// <summary>Adds a new entity to the repository.</summary>
    /// <param name="entity">The entity that must be added to the repository.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <returns>The entity with the most recent values.</returns>
    protected abstract T AddEntityCore(T entity, DataSourceInfo dataSourceInfo);

    /// <summary>Updates the repository with the changes made to the entity.</summary>
    /// <param name="entity">The entity whose members are updated.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <returns>The entity with the most recent values.</returns>
    protected abstract T UpdateEntityCore(T entity, DataSourceInfo dataSourceInfo);

    /// <summary>Deletes the entity from the repository.</summary>
    /// <param name="entity">The entity that must be deleted.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    protected abstract void DeleteEntityCore(T entity, DataSourceInfo dataSourceInfo);

    /// <summary>Finds all the available entities that match the specified expression.</summary>
    /// <param name="expression">The expression to which the entities must match.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <returns>The entities that match the specified expression.</returns>
    protected abstract IEnumerable<T> FindAllCore(Func<T, bool> expression, DataSourceInfo dataSourceInfo);

    /// <summary>Finds a single entity that matches the expression. If no result was found, the specified default-value
    /// is returned.</summary>
    /// <param name="expression">The expression to which the entity must match.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <param name="defaultValue">The value that will be returned when no match was found.</param>
    /// <returns>The found entity or <paramref name="defaultValue"/> if there was no result.</returns>
    protected abstract T FindSingleCore(Func<T, bool> expression, DataSourceInfo dataSourceInfo, T defaultValue);

    /// <summary>Finds the first entity that matches the expression. If no result was found, the specified default-value
    /// is returned.</summary>
    /// <param name="expression">The expression to which the entity must match.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <param name="defaultValue">The value that will be returned when no match was found.</param>
    /// <returns>The found entity or <paramref name="defaultValue"/> if there was no result.</returns>
    protected abstract T FindFirstCore(Func<T, bool> expression, DataSourceInfo dataSourceInfo, T defaultValue);

    /// <summary>Finds all the entities of type <typeparamref name="T"/>.</summary>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <returns>All the available entities.</returns>
    protected virtual IEnumerable<T> FindAllCore(DataSourceInfo dataSourceInfo) {
      return this.FindAllCore(t => true, dataSourceInfo);
    }

    /// <summary>Finds a single entity that matches the expression.</summary>
    /// <param name="expression">The expression to which the entity must match.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <returns>The found entity.</returns>
    protected virtual T FindSingleCore(Func<T, bool> expression, DataSourceInfo dataSourceInfo) {
      return this.FindSingleCore(expression, dataSourceInfo, null);
    }

    /// <summary>Finds the first single entity that matches the expression.</summary>
    /// <param name="expression">The expression to which the entity must match.</param>
    /// <param name="dataSourceInfo">Information about the datasource that may not have been set at an earlier stage.</param>
    /// <returns>The found entity.</returns>
    protected virtual T FindFirstCore(Func<T, bool> expression, DataSourceInfo dataSourceInfo) {
      return this.FindFirstCore(expression, dataSourceInfo, null);
    }

    /// <summary>Creates an AND-expression using the two specified specifications.</summary>
    /// <param name="leftOperand">The left operand of the combination.</param>
    /// <param name="rightOperand">The right operand of the combination.</param>
    /// <returns>The created expression.</returns>
    protected virtual Func<T, bool> CreateAndExpressionCore(ISpecification<T> leftOperand, ISpecification<T> rightOperand) {
      return t => leftOperand.Visit(this)(t) && rightOperand.Visit(this)(t);
    }

    /// <summary>Creates an OR-expression using the two specified specifications.</summary>
    /// <param name="leftOperand">The left operand of the combination.</param>
    /// <param name="rightOperand">The right operand of the combination.</param>
    /// <returns>The created expression.</returns>
    protected virtual Func<T, bool> CreateOrExpressionCore(ISpecification<T> leftOperand, ISpecification<T> rightOperand) {
      return t => leftOperand.Visit(this)(t) || rightOperand.Visit(this)(t);
    }

    /// <summary>Creates a lambda-expression using the specified expression. Typically, this method simply returns the 
    /// parameter.</summary>
    /// <param name="expression">The expression that was originally passed to the specification.</param>
    /// <returns>The created expression.</returns>
    protected virtual Func<T, bool> CreateLambdaExpressionCore(Func<T, bool> expression) {
      return expression;
    }

    /// <summary>Creates a LIKE-expression using the specified field and searchpattern.</summary>
    /// <param name="field">The field of type <c>T</c> that must match the pattern.</param>
    /// <param name="pattern">The pattern to which the field must apply. The pattern may contain a '*' and '?' wildcard.
    /// </param>
    /// <returns>The created expression.</returns>
    protected virtual Func<T, bool> CreateLikeExpressionCore(Func<T, string> field, string pattern) {
      pattern = pattern.Replace("*", ".*").Replace("?", ".?");
      return t => Regex.IsMatch(field(t), pattern);
    }

    /// <summary>Creates a lambda-expression using the custom specification. This method is executed when a 
    /// specification-type is used that is not part of the default specification system.</summary>
    /// <param name="specification">The custom specification.</param>
    /// <returns>The created expression.</returns>
    protected virtual Func<T, bool> CreateCustomExpressionCore(ISpecification<T> specification) {
      throw new NotSupportedException("Specification-type {" + specification.GetType() + "} is not supported");
    }
    #endregion
  }
}
