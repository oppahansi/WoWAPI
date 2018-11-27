# wowapi

Project just started. Not much to see here atm.

## Quick Info
 
WOWAPI will be a restful api delivering data from cmangos classic, tbc and trinity wotlk databases.  
Currently Classic part is under way, NPC and NPCS searching works.

More info later.

## Tech

If you are interested in that you should be able to get the info from the .csproj file :) 

## Why?

Learning more about Restful APIs, ASP NET Core, new C# stuff and general interest in building a base for twinstar like twinhead systems.

## Currently working examples
  
Base endpoints:  
https://localhost:5001/api/c/npcs  
https://localhost:5001/api/c/items  
https://localhost:5001/api/c/itemsets  
  
NPCS default result : https://paste2.org/xgcjz4BP  
ITEMS default result : https://paste2.org/329nc6DE  
ITEMSETS default results: https://paste2.org/N14JHYaZ  
  
Individual items endpoints can be like:  
https://localhost:5001/api/c/npcs/123  
https://localhost:5001/api/c/items/123  
https://localhost:5001/api/c/itemsets/123  
  
  
Results can be filtered using url parameters:  
https://localhost:5001/api/c/npcs?parameter=value  
https://localhost:5001/api/c/npcs?name=qiraji  

Available filter parameters will be listed later but you can take a look at *FilterParams.cs files to get an idea.  
Furthermore there are currently 2 filter modes:  
  
ANY = if any url paramter matches it is a hit  
ALL = all url parameter have to match  
  
Sorting is also supported. Sorting types will be listed later but basically you can sort by anything that is in a model class available.  
