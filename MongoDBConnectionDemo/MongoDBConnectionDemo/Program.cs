using System;
using MongoDB.Driver;
using MongoDB.Bson;


namespace MongoDBConnectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MongoClient db_client = new MongoClient("mongodb://localhost:27017/");
            var db_list = db_client.ListDatabases().ToList();
            Console.WriteLine("Lista de bases Mongo");
            foreach(var db in db_list)
            {
                Console.WriteLine(db);
            }
            //Console.ReadLine();

            var data_base = db_client.GetDatabase("admin");//tengo las facturas
            var collection = data_base.GetCollection<BsonDocument>("Facturas");
            var firstDocument = collection.Find(new BsonDocument()).FirstOrDefault();
            Console.WriteLine(firstDocument.ToString());

            var filter_by_client = Builders<BsonDocument>.Filter.Eq("nro_factura", 1000);
            //foreach (var doc in filter_by_client.)
            Console.ReadLine();

        }
    }
}
