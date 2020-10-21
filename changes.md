## Changes

#### IView 

- GetInput with new return type
```csharp
int GetInput()
``` 
changed to 
```csharp 
Input GetInput()
```

#### SimpleView
- Adding constants for menuoptions.

#### SwedishView
- Adding constants for menuoptions.

#### Dealer

- Adding a new method to remove duplicated code for dealing a card.

```csharp 
public void DealCard(Player a_player, bool shouldShow)
{
    Card c;
    c = m_deck.GetCard();
    c.Show(shouldShow);
    a_player.ReceiveCard(c);
}
```

#### Player

- Changed method name from DealCard to RecieveCard

## Additions

- IWinCondition
- BasicWinCondition
- Soft17Strategy
