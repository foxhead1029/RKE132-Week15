
List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies{movie.Title} was released in {movie.Year}");
}

static string[] GetDataFromMyFile()
{
    string filepath = @"C:\Users\hanni\Desktop\Kool\Programeerimise_algkursus\data\movies.txt";
    return File.ReadAllLines(filepath);
} 

static void ReadDataFromArray(string[] someArry)
{
    foreach (string line in someArry)
    {
        Console.WriteLine(line);
    }
}



class Movie
{
    string title;
    string year;

    public string Title
    {
        get { return title; } 
    }
    public string Year
    {
        get { return year; } 
    }
    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}