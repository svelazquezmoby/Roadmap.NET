using DocumentFormat.OpenXml.Bibliography;
using System;

var queue = new Queue<Artist>();

queue.Enqueue(new Artist
{
    GenreId = "Neue Deutsche Härte",
    Name = "Rammstein",
    RecordId = 1
});
queue.Enqueue(new Artist
{
    GenreId = "Neue Deutsche Härte",
    Name = "OOMPH!",
    RecordId = 2
});
queue.Enqueue(new Artist
{
    GenreId = "Neue Deutsche Härte",
    Name = "Eisbrecher",
    RecordId = 3
});