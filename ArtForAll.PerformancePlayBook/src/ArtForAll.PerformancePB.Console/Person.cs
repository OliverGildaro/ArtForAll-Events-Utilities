namespace ArtForAll.PerformancePB.Console
{
    public class PersonClass
    {
        public string Name { get; set; }
    }


    //WHEN TO USE STRUCTS
    //For less than 16 bytes
    //Small inmutable data
    //Doen't need to be boxed frequently
    //Not shared across diferent aggregates
    public struct PersonStruct
    {
        public string Name { get; set; }
    }

    //record seems to be nly syntactic sugar
    public record PersonRecord(string Name);

    public record struct PersonStructRecord(string Name);
}
