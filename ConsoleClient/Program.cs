using MusicLibrary;

var freddie = new Artist { Name = "Freddie Mercury", DateOfBirth = new DateTime(1946, 9, 5) };

var song1 = new Song("Barcelona", freddie, Genre.Rock, 5.39);
var song2 = new Song("La Japonaise", freddie, Genre.Rock, 4.49);
var song3 = new Song("The Fallen Priest", freddie, Genre.Rock, 5.46);
var song4 = new Song("Ensueño", freddie, Genre.Rock, 4.21);
var song5 = new Song("The Golden Boy", freddie, Genre.Rock, 6.05);
var song6 = new Song("Guide Me Home", freddie, Genre.Rock, 2.49);
var song7 = new Song("How Can I Go On", freddie, Genre.Rock, 3.51);
var song8 = new Song("Overture Piccante", freddie, Genre.Rock, 6.40);

var barselona = new Album("Barcelona", freddie);
barselona.AddSong(song1);
barselona.AddSong(song2);
barselona.AddSong(song3);
barselona.AddSong(song4);
barselona.AddSong(song5);
barselona.AddSong(song6);
barselona.AddSong(song7);
barselona.AddSong(song8);

var player = MusicPlayer.Instance;
player.AddAlbum(barselona);
player.SelectAlbum("Barcelona");

player.Play();
player.Pause();
player.Next();

var customPlaylist = new List<Song> { song1, song3 };
player.CreatePlaylist(customPlaylist);

player.Play();
