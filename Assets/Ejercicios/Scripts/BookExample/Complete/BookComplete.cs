using UnityEngine;

[CreateAssetMenu(menuName = "Design/Book", fileName = "Book")]
public class BookComplete : ScriptableObject
{
	[SerializeField] private string bookName;
	public string BookName => bookName;
	[SerializeField] private string author;
	public string Author => author;
	[SerializeField] private int year;
	public int Year => year;
	[SerializeField] private BookGenreComplete genre;
	public BookGenreComplete Genre => genre;
	[SerializeField] private BookTopicComplete topics;
	public BookTopicComplete Topics => topics;
}