using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PartySquirrel.Models
{
  public class RandomThing
  {
    public static string RandomName()
    {
      Random rand = new Random();
      int randomIndex = rand.Next(0, _nameList.Length);
      return _nameList[randomIndex];
    }

    public static string RandomFont()
    {
      Random rand = new Random();
      int randomIndex = rand.Next(0, _fontList.Length);
      return _fontList[randomIndex];
    }

    private static String[] _fontList =
    {
      "font-family: 'Aclonica', sans-serif;",
      "font-family: 'Almendra', serif;",
      "font-family: 'Amita', cursive;",
      "font-family: 'Arbutus', cursive;",
      "font-family: 'Audiowide', cursive;",
      "font-family: 'Barriecito', cursive;",
      "font-family: 'Creepster', cursive;",
      "font-family: 'Do Hyeon', sans-serif;",
      "font-family: 'Dokdo', cursive;",
      "font-family: 'Faster One', cursive;",
      "font-family: 'Geo', sans-serif;",
      "font-family: 'IM Fell DW Pica', serif;",
      "font-family: 'Irish Grover', cursive;",
      "font-family: 'Macondo Swash Caps', cursive;",
      "font-family: 'MedievalSharp', cursive;",
      "font-family: 'Metal Mania', cursive;",
      "font-family: 'Monoton', cursive;",
      "font-family: 'Russo One', sans-serif;",
      "font-family: 'Saira Stencil One', cursive;",
      "font-family: 'Shojumaru', cursive;",
      "font-family: 'Short Stack', cursive;",
      "font-family: 'Snowburst One', cursive;",
      "font-family: 'Staatliches', cursive;",
      "font-family: 'Trade Winds', cursive;",
      "font-family: 'Turret Road', cursive;",
      "font-family: 'UnifrakturCook', cursive;",
      "font-family: 'Vampiro One', cursive;",
      "font-family: 'Vibes', cursive;",
      "font-family: 'VT323', monospace;",
      "font-family: 'Walter Turncoat', cursive;",
      "font-family: 'Wendy One', sans-serif;",
      "font-family: 'Yatra One', cursive;"
    };
    private static String[] _nameList = 
    {
      "Zen",
      "Milkshake",
      "Zion",
      "Bubbles",
      "Saki",
      "Coffee",
      "Nebula",
      "Ernie",
      "Shelby",
      "Licker",
      "Escobar",
      "Isotope",
      "Einstein",
      "Francisco",
      "Guru",
      "Scarlet",
      "Sausage",
      "Haste",
      "Maniac",
      "Armani",
      "Swift",
      "Aaliyah",
      "Florence",
      "Beaker",
      "Magnet",
      "Tilt",
      "Benedict",
      "Tootsie",
      "Zippy",
      "Hazel",
      "Archie",
      "Sinbad",
      "Chapo",
      "Senior",
      "Polo",
      "Nautica",
      "Harry",
      "Chowder",
      "Artimus",
      "Blueberry",
      "Teddy",
      "Cartman",
      "Rock",
      "Barker",
      "Rave",
      "Nixon",
      "Raven",
      "Dracula",
      "Ox",
      "Jester",
      "Carlito",
      "Nugget",
      "Leo",
      "Fivel",
      "Goon",
      "Paleo",
      "Aretha",
      "Mary Jane",
      "Kelsey",
      "Gatsby",
      "Soup",
      "Link",
      "Pickle",
      "Lemming",
      "Kabuki",
      "Tigger",
      "Ozzy",
      "Remy",
      "Herman",
      "Sage",
      "Marshmallow",
      "Willy",
      "Gato",
      "Twilight",
      "Mullet",
      "Elm",
      "Alpine",
      "Strawberry",
      "Page",
      "Goosebumps",
      "Egbert",
      "Smooth",
      "Lyric",
      "Mutant",
      "Kahlua",
      "Satay",
      "Crawler",
      "Winston",
      "Houdini",
      "Sheba",
      "Fuzzbucket",
      "Rockford",
      "Yoda",
      "Maru",
      "Gordy",
      "Kane",
      "Rich",
      "Scar",
      "Pixie",
      "Cutie",
      "Dorito",
      "Claw",
      "Java",
      "Fenway",
      "Jazzy",
      "Tophat",
      "Tech",
      "Lava",
      "Jelly",
      "Salvador",
      "Reno",
      "Omar",
      "Stormy",
      "Moto",
      "Howard",
      "Quirk",
      "Zap",
      "Trigger",
      "Fitch",
      "Pierce",
      "Gobble",
      "Dancer",
      "Audrey",
      "Greco",
      "Cannabis",
      "Amber",
      "Spree",
      "Toon",
      "Chubby",
      "Bagel",
      "Flash",
      "Sprint",
      "Wacky",
      "Avery",
      "Igloo",
      "Galileo",
      "Alvin",
      "Babe",
      "Elastic",
      "Runt",
      "Magnus",
      "Paws",
      "Dragon",
      "Zim",
      "Cheyenne",
      "Scuttle",
      "Moses",
      "Wolf",
      "Sparkle",
      "Gin",
      "Portal",
      "Slim",
      "Shamu",
      "Wilson",
      "Odie",
      "Sasha",
      "Pierre",
      "Joy",
      "Dollar",
      "Simon",
      "Bond",
      "Roger",
      "Daft",
      "Mecca",
      "Jambalaya",
      "Button",
      "Khan",
      "Lotto",
      "Chevy",
      "Anita",
      "Relish",
      "Muse",
      "Virgil",
      "Ruffle",
      "Zoom",
      "Nano",
      "Nelson",
      "Shaker",
      "Neo",
      "Birch",
      "Orville",
      "Ion",
      "Banjo",
      "Scruff",
      "Lulu",
      "Grunt",
      "Swag",
      "Abyss",
      "Destiny",
      "Taz",
      "Kodiak",
      "Ableton",
      "Jasmine",
      "Sigma",
      "Angelo",
      "Ramsey",
      "Linus",
      "Juno",
      "Digger",
      "Jerky",
      "Scamp",
      "Vice",
      "Champ",
      "Mario",
      "Bulbasaur",
      "Nimbus",
      "Jumanji",
      "Champagne",
      "Ramen",
      "Peggy",
      "Syrup",
      "Newman",
      "Gucci",
      "Kimbo",
      "Buddha",
      "Puff",
      "Lola",
      "Aspen",
      "Kamikaze",
      "Starsky",
      "Sosa",
      "Patches",
      "Chen",
      "Tater Tot",
      "Uno",
      "Ewok",
      "Mozzarella",
      "Warp",
      "Oatmeal",
      "Slayer",
      "Money",
      "Tico",
      "Ryder",
      "Rugged",
      "Mars",
      "Vixen",
      "Fade",
      "Scotch",
      "Zip",
      "Crouton",
      "Mona",
      "Luigi",
      "Sponge",
      "Precious",
      "Weezy",
      "Kale",
      "Maximus",
      "Shy",
      "Speedy",
      "Galaxy",
      "Rupert",
      "Chocolate",
      "Tank",
      "Checker",
      "Oreo",
      "Snowball",
      "Prancer",
      "Sid",
      "Zoey",
      "Bojangles",
      "Sprite",
      "Onion",
      "Bentley",
      "Dustin",
      "Power",
      "Waffle",
      "Titan",
      "Cub",
      "Ivy",
      "Halo",
      "Paco",
      "Toke",
      "Spam",
      "Adobe",
      "Mulder",
      "Rapture",
      "Ray",
      "Tumbleweed",
      "Baldy",
      "Pistol",
      "Meta",
      "Tang",
      "Remington",
      "Volt",
      "Brady",
      "Linux",
      "Bozo",
      "Pongo",
      "Skylar",
      "Electron",
      "Enya",
    };
  }
}