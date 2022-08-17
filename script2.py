import csv


#new Country
#                    {
#                        country_name = "",
#                        image_name = ,
#                        
#                    },

def createString(country, image):
    return f'new Country\n{{\n\tcountry_name = "{country}",\n\timage_name = "{image}",\n}},\n\n'


with open("list_country.csv", 'r') as list, open("seed.txt", 'w') as output:
    csv_file = csv.DictReader(list)
    for row in csv_file:
        s = createString(row["country_name"], row["image_name"])
        output.write(s)

    
