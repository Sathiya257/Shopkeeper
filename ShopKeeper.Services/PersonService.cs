using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using ShopKeeper.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopKeeper.Services;

public class PersonService
{
    private readonly IMongoCollection<Person> _personCollection;
    public PersonService(IConfiguration mongoSettings)
    {
       
        var client = new MongoClient(mongoSettings.GetSection("MongoSettings:ConnectionString").Value);
        var database = client.GetDatabase(mongoSettings.GetSection("MongoSettings:DatabaseName").Value);
        _personCollection = database.GetCollection<Person>(mongoSettings.GetSection("MongoSettings:CollectionName").Value);
        
//var client = new MongoClient(settings);

    }
    

    public async Task<List<Person>> GetAllPersonsAsync()
    {
        // Fetch all persons from the MongoDB collection
        try
        {
            return await _personCollection.Find(person => true).ToListAsync();
        }
        catch (System.Exception )
        {
            
            throw ;
        }
        
    }


}
