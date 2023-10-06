# Mob Programming

goal: remove all `Display` functions from the program, replacing them with `ToString`

1. update `MenuItem` to override `ToString` with the logic in display
2. update each implementing classes display to use `MenuItem`'s `ToString` method