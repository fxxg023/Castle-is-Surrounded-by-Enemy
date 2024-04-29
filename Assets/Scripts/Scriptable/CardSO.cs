using UnityEngine;

[CreateAssetMenu(fileName = "CardSO", menuName = "SO/CardSO", order = 1)]
public class CardSO : ScriptableObject {
    public enum CardType
    {
        common,
        consumption,
        remove,
    }
    public enum RarityType
    {
        common,
        rare,
        legendary,
    }
    public string cardName;
    public string cardDescription;
    public int cost;
    public GameObject gameObject;
    public GameObject cardObject;
    public CardType cardType;
    public RarityType rarityType;
    // public int discardedCost;
}
