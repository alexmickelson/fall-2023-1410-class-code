public record Pokemon(
  string Id,
  string Name,
  string Type1,
  string Type2,
  int Total,
  int HP,
  int Attack,
  int Defense,
  int SpecialAttack,
  int SpecialDefense,
  int Speed,
  string Generation,
  bool Legendary = false
);