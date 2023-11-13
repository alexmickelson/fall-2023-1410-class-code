public record Pokemon(
  string Id,
  string Name,
  string Type1,
  string Type2,
  int HP,
  int Attack,
  int Defense,
  int SpecialAttack,
  int SpecialDefense,
  int Speed,
  string Generation = "",
  int Total = -1,
  bool Legendary = false
);