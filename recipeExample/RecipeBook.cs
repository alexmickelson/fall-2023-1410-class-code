using System.Text;

public class RecipeBook
{
  private Dictionary<string, Recipe> recipes { get; set; } = new();

  public RecipeBook()
  {
    AddRecipes(recipes);
  }

  public override string ToString()
  {
    var builder = new StringBuilder();

    foreach (KeyValuePair<string, Recipe> item in recipes)
    {
      builder.Append(item.Value.ToString() + Environment.NewLine);
    }

    return builder.ToString();
  }

  public Recipe GetRandomRecipe()
  {
    var randomGenerator = new Random();

    var recipesKeys = recipes.Keys.ToList();
    var randomKeyIndex = randomGenerator.Next(recipesKeys.Count);
    var randomKey = recipesKeys[randomKeyIndex];

    return recipes[randomKey];
  }

  private void AddRecipes(Dictionary<string, Recipe> recipes)
  {
    recipes.Add("Spaghetti Carbonara", new Recipe
    {
      Title = "Spaghetti Carbonara",
      Ingredients = new List<string>
      {
        "200g spaghetti",
        "100g pancetta or guanciale",
        "2 large eggs",
        "50g Pecorino Romano cheese",
        "50g Parmesan cheese",
        "2 cloves garlic",
        "Salt and black pepper to taste"
      },
      Instructions = new List<string>
      {
        "Cook spaghetti according to package instructions.",
        "In a separate pan, cook pancetta or guanciale until crispy.",
        "In a bowl, whisk together eggs, grated cheeses, minced garlic, and black pepper.",
        "Drain cooked pasta and quickly toss it with the egg and cheese mixture.",
        "Add crispy pancetta/guanciale on top and serve."
      }
    });

    recipes.Add("Chicken Alfredo", new Recipe
    {
      Title = "Chicken Alfredo",
      Ingredients = new List<string>
      {
        "8 oz fettuccine pasta",
        "2 boneless, skinless chicken breasts",
        "1 cup heavy cream",
        "1/2 cup grated Parmesan cheese",
        "2 cloves garlic, minced",
        "2 tablespoons butter",
        "Salt and black pepper to taste"
      },
      Instructions = new List<string>
      {
        "Cook fettuccine pasta according to package instructions.",
        "Season chicken breasts with salt and pepper and cook until no longer pink.",
        "In a saucepan, melt butter and sauté minced garlic.",
        "Add heavy cream and Parmesan cheese, stirring until smooth.",
        "Slice cooked chicken and add it to the sauce.",
        "Serve the sauce over cooked fettuccine pasta."
      }
    });

    recipes.Add("Caesar Salad", new Recipe
    {
      Title = "Caesar Salad",
      Ingredients = new List<string>
      {
        "1 head of Romaine lettuce",
        "1/4 cup grated Parmesan cheese",
        "1/4 cup croutons",
        "1/4 cup Caesar salad dressing",
        "1 clove garlic, minced",
        "1/2 lemon, juiced",
        "Salt and black pepper to taste"
      },
      Instructions = new List<string>
      {
        "Wash and chop Romaine lettuce into bite-sized pieces.",
        "In a bowl, combine minced garlic, lemon juice, and Caesar dressing.",
        "Toss the lettuce with the dressing mixture, grated Parmesan, and croutons.",
        "Season with salt and black pepper to taste."
      }
    });

    recipes.Add("Chocolate Chip Cookies", new Recipe
    {
      Title = "Chocolate Chip Cookies",
      Ingredients = new List<string>
      {
        "2 1/4 cups all-purpose flour",
        "1/2 teaspoon baking soda",
        "1 cup unsalted butter, room temperature",
        "1/2 cup granulated sugar",
        "1 cup packed light-brown sugar",
        "1 teaspoon salt",
        "2 teaspoons pure vanilla extract",
        "2 large eggs",
        "2 cups semisweet and/or milk chocolate chips"
      },
      Instructions = new List<string>
      {
        "Preheat oven to 350°F (175°C).",
        "In a small bowl, whisk together flour and baking soda.",
        "In a large bowl, beat butter, granulated sugar, brown sugar, and salt until creamy.",
        "Add vanilla extract and eggs, one at a time, beating well after each addition.",
        "Gradually add the flour mixture and stir in chocolate chips.",
        "Drop dough by rounded tablespoons onto ungreased baking sheets.",
        "Bake for 9 to 11 minutes or until golden brown.",
        "Cool on baking sheets for a few minutes, then transfer to wire racks to cool completely."
      }
    });
    recipes.Add("Chicken Parmesan", new Recipe
    {
      Title = "Chicken Parmesan",
      Ingredients = new List<string>
      {
        "4 boneless, skinless chicken breasts",
        "1 cup bread crumbs",
        "1/2 cup grated Parmesan cheese",
        "1 cup marinara sauce",
        "1 cup shredded mozzarella cheese",
        "2 tablespoons olive oil",
        "Salt and black pepper to taste"
      },
      Instructions = new List<string>
      {
        "Preheat oven to 375°F (190°C).",
        "Season chicken breasts with salt and pepper.",
        "Coat chicken with bread crumbs and Parmesan cheese.",
        "In a large skillet, heat olive oil and cook chicken until browned on both sides.",
        "Place chicken in a baking dish, top with marinara sauce and mozzarella cheese.",
        "Bake for 25-30 minutes or until chicken is cooked through and cheese is bubbly."
      }
    });

    recipes.Add("Greek Salad", new Recipe
    {
      Title = "Greek Salad",
      Ingredients = new List<string>
      {
        "1 cucumber, sliced",
        "1 cup cherry tomatoes, halved",
        "1/2 red onion, thinly sliced",
        "1/2 cup Kalamata olives",
        "4 oz feta cheese, crumbled",
        "2 tablespoons extra virgin olive oil",
        "1 tablespoon red wine vinegar",
        "1 teaspoon dried oregano",
        "Salt and black pepper to taste"
      },
      Instructions = new List<string>
      {
        "In a large bowl, combine cucumber, cherry tomatoes, red onion, olives, and feta cheese.",
        "In a small bowl, whisk together olive oil, red wine vinegar, dried oregano, salt, and black pepper.",
        "Pour the dressing over the salad and toss to combine."
      }
    });

    recipes.Add("Pancakes", new Recipe
    {
      Title = "Pancakes",
      Ingredients = new List<string>
      {
        "1 cup all-purpose flour",
        "2 tablespoons sugar",
        "1 teaspoon baking powder",
        "1/2 teaspoon baking soda",
        "1/4 teaspoon salt",
        "1 cup buttermilk",
        "1 egg",
        "2 tablespoons melted butter",
        "Maple syrup for serving"
      },
      Instructions = new List<string>
      {
        "In a bowl, whisk together flour, sugar, baking powder, baking soda, and salt.",
        "In another bowl, whisk together buttermilk, egg, and melted butter.",
        "Pour wet ingredients into dry ingredients and stir until just combined.",
        "Heat a griddle or non-stick skillet over medium-high heat and ladle pancake batter onto the griddle.",
        "Cook until bubbles form on the surface, then flip and cook until golden brown on the other side.",
        "Serve with maple syrup."
      }
    });

    recipes.Add("Chicken Stir-Fry", new Recipe
    {
      Title = "Chicken Stir-Fry",
      Ingredients = new List<string>
      {
        "2 boneless, skinless chicken breasts, sliced",
        "2 cups mixed vegetables (bell peppers, broccoli, carrots)",
        "2 cloves garlic, minced",
        "2 tablespoons soy sauce",
        "1 tablespoon hoisin sauce",
        "1 tablespoon vegetable oil",
        "1 teaspoon cornstarch",
        "Rice for serving"
      },
      Instructions = new List<string>
      {
        "In a small bowl, whisk together soy sauce, hoisin sauce, and cornstarch.",
        "Heat vegetable oil in a large skillet or wok over high heat.",
        "Add sliced chicken and stir-fry until cooked through.",
        "Add minced garlic and mixed vegetables and stir-fry for a few minutes.",
        "Pour the sauce mixture over the stir-fry and cook until the sauce thickens.",
        "Serve over rice."
      }
    });

    recipes.Add("Chocolate Cake", new Recipe
    {
      Title = "Chocolate Cake",
      Ingredients = new List<string>
      {
        "1 3/4 cups all-purpose flour",
        "1 1/2 teaspoons baking powder",
        "1 1/2 teaspoons baking soda",
        "1 cup unsweetened cocoa powder",
        "2 cups granulated sugar",
        "2 eggs",
        "1 cup buttermilk",
        "1/2 cup vegetable oil",
        "2 teaspoons vanilla extract",
        "1 cup boiling water"
      },
      Instructions = new List<string>
      {
        "Preheat oven to 350°F (175°C). Grease and flour two 9-inch round cake pans.",
        "In a large bowl, sift together flour, baking powder, baking soda, cocoa powder, and sugar.",
        "Add eggs, buttermilk, vegetable oil, and vanilla extract. Beat until smooth.",
        "Stir in boiling water until the batter is thin.",
        "Pour evenly into the prepared pans.",
        "Bake for 30 to 35 minutes or until a toothpick inserted into the center comes out clean.",
        "Allow cakes to cool completely before frosting."
      }
    });
  }
}