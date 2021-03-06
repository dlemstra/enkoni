﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Enkoni.Framework.DataAnnotations.Configuration {
  /// <summary>Defines a custom dictionary that holds the <see cref="DutchPhoneNumberValidationConfigElement"/> that were read from the configuration
  /// file.</summary>
  public class DutchPhoneNumberValidationConfigDictionary : IDictionary<string, DutchPhoneNumberValidationConfigElement> {
    #region Instance variables

    /// <summary>The actual storage.</summary>
    private Dictionary<string, DutchPhoneNumberValidationConfigElement> storage;

    #endregion

    #region Constructor

    /// <summary>Initializes a new instance of the <see cref="DutchPhoneNumberValidationConfigDictionary"/> class.</summary>
    public DutchPhoneNumberValidationConfigDictionary() {
      this.storage = new Dictionary<string, DutchPhoneNumberValidationConfigElement>();
    }

    #endregion

    #region Properties

    /// <summary>Gets an <see cref="ICollection{T}"/> containing the keys of the <see cref="IDictionary{TKey,TValue}"/>.</summary>
    public ICollection<string> Keys {
      get { return this.storage.Keys; }
    }

    /// <summary>Gets an <see cref="ICollection{T}"/> containing the values of the <see cref="IDictionary{TKey,TValue}"/>.</summary>
    public ICollection<DutchPhoneNumberValidationConfigElement> Values {
      get { return this.storage.Values; }
    }

    /// <summary>Gets the number of elements contained in the <see cref="ICollection{T}"/>.</summary>
    public int Count {
      get { return this.storage.Count; }
    }

    /// <summary>Gets a value indicating whether the <see cref="ICollection{T}"/> is read-only.</summary>
    public bool IsReadOnly {
      get { return false; }
    }

    /// <summary>Gets or sets the element with the specified key.</summary>
    /// <param name="key">The key of the element to get or set.</param>
    /// <returns>The element with the specified key.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="key"/> is <see langword="null"/>.</exception>
    public DutchPhoneNumberValidationConfigElement this[string key] {
      get {
        if(this.storage.ContainsKey(key)) {
          return this.storage[key];
        }
        else if(this.storage.ContainsKey(DutchPhoneNumberAttribute.DefaultName)) {
          return this.storage[DutchPhoneNumberAttribute.DefaultName];
        }
        else {
          return null;
        }
      }

      set {
        this.storage[key] = value;
      }
    }

    #endregion

    #region Public methods

    /// <summary>Adds an element with the provided key and value to the <see cref="IDictionary{TKey,TValue}"/>.</summary>
    /// <param name="key">The object to use as the key of the element to add.</param>
    /// <param name="value">The object to use as the value of the element to add.</param>
    /// <exception cref="ArgumentNullException"><paramref name="key"/> is <see langword="null"/>.</exception>
    /// <exception cref="ArgumentException">An element with the same key already exists in the <see cref="IDictionary{TKey,TValue}"/>.</exception>
    public void Add(string key, DutchPhoneNumberValidationConfigElement value) {
      this.storage.Add(key, value);
    }

    /// <summary>Adds an item to the <see cref="ICollection{T}"/>.</summary>
    /// <param name="item">The object to add to the <see cref="ICollection{T}"/>.</param>
    public void Add(KeyValuePair<string, DutchPhoneNumberValidationConfigElement> item) {
      ((IDictionary<string, DutchPhoneNumberValidationConfigElement>)this.storage).Add(item);
    }

    /// <summary>Determines whether the <see cref="ICollection{T}"/> contains a specific value.</summary>
    /// <param name="item">The object to locate in the <see cref="ICollection{T}"/>.</param>
    /// <returns><see langword="true"/> if item is found in the <see cref="ICollection{T}"/>; otherwise, <see langword="false"/>.</returns>
    public bool Contains(KeyValuePair<string, DutchPhoneNumberValidationConfigElement> item) {
      return this.Contains(item);
    }

    /// <summary>Determines whether the <see cref="IDictionary{TKey,TValue}"/> contains an element with the specified key.</summary>
    /// <param name="key">The key to locate in the <see cref="IDictionary{TKey,TValue}"/>.</param>
    /// <returns><see langword="true"/> if the <see cref="IDictionary{TKey,TValue}"/> contains an element with the key; otherwise,
    /// <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="key"/> is <see langword="null"/>.</exception>
    public bool ContainsKey(string key) {
      return this.storage.ContainsKey(key);
    }

    /// <summary>Removes the element with the specified key from the <see cref="IDictionary{TKey,TValue}"/>.</summary>
    /// <param name="key">The key of the element to remove.</param>
    /// <returns><see langword="true"/> if the element is successfully removed; otherwise, <see langword="false"/>. This method also returns
    /// <see langword="false"/> if <paramref name="key"/> was not found in the original <see cref="IDictionary{TKey,TValue}"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="key"/> is <see langword="null"/>.</exception>
    public bool Remove(string key) {
      return this.storage.Remove(key);
    }

    /// <summary>Removes the first occurrence of a specific object from the <see cref="ICollection{T}"/>.</summary>
    /// <param name="item">The object to remove from the <see cref="ICollection{T}"/>.</param>.
    /// <returns><see langword="true"/> if item was successfully removed from the <see cref="ICollection{T}"/>; otherwise, <see langword="false"/>.
    /// This method also returns <see langword="false"/> if item is not found in the original <see cref="ICollection{T}"/>.</returns>
    public bool Remove(KeyValuePair<string, DutchPhoneNumberValidationConfigElement> item) {
      return ((IDictionary<string, DutchPhoneNumberValidationConfigElement>)this.storage).Remove(item);
    }

    /// <summary>Gets the value associated with the specified key.</summary>
    /// <param name="key">The key whose value to get.</param>
    /// <param name="value">When this method returns, the value associated with the specified key, if the key is found; otherwise, the default value
    /// for the type of the value parameter. This parameter is passed uninitialized.</param>
    /// <returns><see langword="true"/> if the object that implements <see cref="IDictionary{TKey,TValue}"/> contains an element with the specified
    /// key; otherwise, <see langword="false"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="key"/> is <see langword="null"/>.</exception>
    public bool TryGetValue(string key, out DutchPhoneNumberValidationConfigElement value) {
      return this.storage.TryGetValue(key, out value);
    }

    /// <summary>Removes all items from the <see cref="ICollection{T}"/>.</summary>
    public void Clear() {
      this.storage.Clear();
    }

    /// <summary>Copies the elements of the <see cref="ICollection{T}"/> to an <see cref="Array"/>, starting at a particular <see cref="Array"/>
    /// index.</summary>
    /// <param name="array">The one-dimensional <see cref="Array"/> that is the destination of the elements copied from <see cref="ICollection{T}"/>.
    /// The <see cref="Array"/> must have zero-based indexing.</param>
    /// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
    /// <exception cref="ArgumentNullException"><paramref name="array"/> is <see langword="null"/>.</exception>
    /// <exception cref="ArgumentOutOfRangeException"><paramref name="arrayIndex"/> is less than 0.</exception>
    /// <exception cref="ArgumentException">The number of elements in the source <see cref="ICollection{T}"/> is greater than the available space from
    /// <paramref name="arrayIndex"/> to the end of the destination array.</exception>
    public void CopyTo(KeyValuePair<string, DutchPhoneNumberValidationConfigElement>[] array, int arrayIndex) {
      ((IDictionary<string, DutchPhoneNumberValidationConfigElement>)this.storage).CopyTo(array, arrayIndex);
    }

    /// <summary>Returns an enumerator that iterates through the collection.</summary>
    /// <returns>A <see cref="IEnumerator{T}"/> that can be used to iterate through the collection.</returns>
    public IEnumerator<KeyValuePair<string, DutchPhoneNumberValidationConfigElement>> GetEnumerator() {
      return this.storage.GetEnumerator();
    }

    /// <summary>Returns an enumerator that iterates through a collection.</summary>
    /// <returns>An <see cref="IEnumerator"/> object that can be used to iterate through the collection.</returns>
    IEnumerator IEnumerable.GetEnumerator() {
      return this.GetEnumerator();
    }

    #endregion
  }
}
