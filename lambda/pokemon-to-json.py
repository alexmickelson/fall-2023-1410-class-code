import csv
import json

def csv_to_json(csv_filename, json_filename):
    """Convert a CSV file to a JSON file."""
    data = []

    with open(csv_filename, 'r') as csv_file:
        csv_reader = csv.DictReader(csv_file)

        for row in csv_reader:
            print(row)
            data.append({
                "Id": row["#"],
                "Name": row["Name"],
                "Type1": row["Type 1"],
                "Type2": row["Type 2"],
                "Total": int(row["Total"]),
                "HP": int(row["HP"]),
                "Attack": int(row["Attack"]),
                "Defense": int(row["Defense"]),
                "SpecialAttack": int(row["Sp. Atk"]),
                "SpecialDefense": int(row["Sp. Def"]),
                "Speed": int(row["Speed"]),
                "Generation": row["Generation"],
                "Legendary": bool(row["Legendary"]),
            })

    with open(json_filename, 'w') as json_file:
        json.dump(data, json_file, indent=4)


csv_to_json('pokemon.csv', 'pokemon.json')
