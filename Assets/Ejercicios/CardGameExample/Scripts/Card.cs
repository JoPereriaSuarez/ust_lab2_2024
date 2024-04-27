using System;
using UnityEngine;

namespace Example.CardGame //namespaces works just like folders, but for code
{
    [CreateAssetMenu(menuName = "Example/Card/Card", fileName = "Card")]
    public class Card : ScriptableObject
    {
        [SerializeField] private string id;
        [SerializeField] private Sprite sprite;
        public Sprite Sprite => sprite;
        [SerializeField] private int cost;
        public int Cost => cost;
        [SerializeField] private string cardName;
        public string Name => cardName;
        [TextArea, SerializeField] private string description;
        public string Description => description;
        [SerializeField] private int strength;
        public int Strength => strength;

        // This can also be achieved using IComparer or IComparable interface
        public int Compare(Card other)
        {
            return string.Compare(other.id, this.id, StringComparison.Ordinal);
        }
    }
}