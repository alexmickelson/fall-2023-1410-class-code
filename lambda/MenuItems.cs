public record MenuItem(
  string Title,
  Action<List<string>> DoTheThing
);