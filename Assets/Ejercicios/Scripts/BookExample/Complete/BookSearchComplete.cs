using System;
using System.Collections.Generic;
using UnityEngine;

public class BookSearchComplete : MonoBehaviour
{
	[SerializeField] private BookComplete[] books;
	[SerializeField] private string bookName;
	[SerializeField] private BookGenreComplete genre;
	[SerializeField] private BookTopicComplete topics;


	[ContextMenu(nameof(SearchWithEnums))]
	public void SearchWithEnums()
	{
		List<BookComplete> result = new();
		for (int i = 0; i < books.Length; i++)
		{
			if ((topics & books[i].Topics) == 0)
				continue;
			
			result.Add(books[i]);
		}

		for (int i = 0; i < result.Count; i++)
		{
			Debug.Log($"Book Name: {result[i].BookName}; Author: {result[i].Author}; Year: {result[i].Year}");
		}
	}
	public void SearchBook()
	{
		BookComplete result = SearchBook(bookName);
		if (result == null)
		{
			Debug.Log($"Cannot find book with name {bookName}");
			return;
		}
		
		Debug.Log($"Book Name: {result.BookName}; Author: {result.Author}; Year: {result.Year}");
	}
	public BookComplete SearchBook(string bookName)
	{
		if (string.IsNullOrEmpty(bookName))
			return null;
		if (books == null || books.Length == 0)
			return null;
		for (int i = 0; i < books.Length; i++)
		{
			if (books[i] == null)
				continue;
			if (string.Compare(bookName, books[i].BookName, StringComparison.OrdinalIgnoreCase) == 0)
				return books[i];
		}

		return null;
	}
}