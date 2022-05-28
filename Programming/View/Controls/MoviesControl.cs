﻿using System;
using Programming.Model;
using Programming.Model.Enums;
using System.Windows.Forms;
using Programming.Model.Movies;
using System.Collections.Generic;

namespace Programming.View.Controls
{
    public partial class MoviesControl : UserControl
    {
        private const int ElementsCount = 5;

        private List<Movie> _movies;

        private Movie _currentMovie;

        public MoviesControl()
        {
            InitializeComponent();

            _movies = InitMovies();
            MovieListBox.SelectedIndex = 0;
        }

        private List<Movie> InitMovies()
        {
            List<Movie> movies = new List<Movie>();
            var genres = Enum.GetValues(typeof(Genre));

            for (int i = 0; i < ElementsCount; i++)
            {
                _currentMovie = MovieFactory.Randomize();
                movies.Add(_currentMovie);
                MovieListBox.Items.Add($"Movie {_currentMovie.Id}");
            }
            return _movies;
        }

        private int FindMovieWithMaxRating(List<Movie> movies)
        {
            int maxRatingIndex = 0;
            double max = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (movies[i].Rating > max)
                {
                    max = movies[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexMovie = MovieListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndexMovie];
            MovieTitleTextBox.Text = _currentMovie.Title;
            MovieGenreTextBox.Text = _currentMovie.Genre;
            MovieReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            MovieDurationMinutesTextBox.Text = _currentMovie.DurationMinutes.ToString();
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void TitleMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            string titleMovie = MovieTitleTextBox.Text;
            _currentMovie.Title = titleMovie;
        }

        private void GenreMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            string genreMovie = MovieGenreTextBox.Text;
            _currentMovie.Genre = genreMovie;
        }

        private void RatingMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRating = MovieRatingTextBox.Text;
                double ratingMovie = double.Parse(currentRating);
                _currentMovie.Rating = ratingMovie;
            }
            catch
            {
                MovieRatingTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            MovieRatingTextBox.BackColor = AppColors.CorrectColor;
        }

        private void ReleaseYearMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentReleaseYear = MovieReleaseYearTextBox.Text;
                int releaseYearMovie = int.Parse(currentReleaseYear);
                _currentMovie.ReleaseYear = releaseYearMovie;
            }
            catch
            {
                MovieReleaseYearTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            MovieReleaseYearTextBox.BackColor = AppColors.CorrectColor;
        }

        private void DurationMinutesMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentDurationMinutes = MovieDurationMinutesTextBox.Text;
                int durationMinutesMovie = int.Parse(currentDurationMinutes);
                _currentMovie.DurationMinutes = durationMinutesMovie;
            }
            catch
            {
                MovieDurationMinutesTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            MovieDurationMinutesTextBox.BackColor = AppColors.CorrectColor;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMovieWithMaxRating(_movies);
            MovieListBox.SelectedIndex = findMaxRatingIndex;
        }
    }
}
