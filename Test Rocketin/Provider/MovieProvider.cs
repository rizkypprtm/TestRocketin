using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test_Rocketin.Model;
using Test_Rocketin.DBContext;

namespace Test_Rocketin.Provider
{
    public class MovieProvider
    {
        private readonly TestEntities context;

        public MovieProvider()
        {
            this.context = new TestEntities();
        }

        public IQueryable<m_movie> getAllMovie()
        {
            var MovieList = context.m_movie;
            return MovieList;
        }

        public List<MovieModel> getAllMovieList(string title, string description, string artist, string genres, int TakeCount, int takePage)
        {
            var data = getAllMovie();
            var result = from movie in getAllMovie()
                         select new MovieModel
                         {
                             id_movie = movie.id_movie,
                             title = movie.title,
                             description = movie.desciption,
                             duration = movie.duration,
                             artis = movie.artist,
                             genres = movie.genres,
                             watch_url = movie.watch_url
                         };



            if (!string.IsNullOrEmpty(title))
            {
                result = result.Where(x => x.title.Contains(title));
            }
            if (!string.IsNullOrEmpty(description))
            {
                result = result.Where(x => x.description.Contains(description));
            }
            if (!string.IsNullOrEmpty(artist))
            {
                result = result.Where(x => x.artis.Contains(artist));
            }
            if (!string.IsNullOrEmpty(genres))
            {
                result = result.Where(x => x.genres.Contains(genres));
            }

            var resultData = result.OrderBy(x => x.id_movie).ToList();

            if (takePage != 0)
            {
                resultData = result.OrderBy(x => x.id_movie).Skip((takePage - 1) * TakeCount)
                            .Take(TakeCount).ToList();

            }

            return resultData;

        }

        public m_movie getMovieById(int id)
        {
            var movie = getAllMovie().Where(x => x.id_movie == id).FirstOrDefault();

            return movie;
        }

        public void InsertMovie(MovieModel entity)
        {
            try
            {
                var movie = new m_movie
                {
                    title = entity.title,
                    desciption = entity.description,
                    duration = entity.duration,
                    artist = entity.artis,
                    genres = entity.genres,
                    watch_url = entity.watch_url,
                    views = 0,
                };
                context.m_movie.Add(movie);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                //return ex.Message.ToString();
                throw;
            }

        }

        public void UpdateMovie(MovieModel entity)
        {
            try
            {
                var movie = getMovieById(entity.id_movie);
                movie.title = entity.title;
                movie.desciption = entity.description;
                movie.artist = entity.artis;
                movie.genres = entity.genres;
                movie.duration = entity.duration;

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                //return ex.Message.ToString();
                throw;
            }

        }

        public void UpdateCountView(int MovieID)
        {
            try
            {
                var movie = getMovieById(MovieID);
                movie.views = movie.views == null? 1 : movie.views + 1 ;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public MovieViewship getMovieViewship()
        {
            var mostViewedMovie = getAllMovie().OrderByDescending(x => x.views).FirstOrDefault();

            var result = new MovieViewship();
            result.most_viewed_id_movie = mostViewedMovie.id_movie;
            result.most_viewed_movie_title = mostViewedMovie.title;
            result.most_viewed_movie_count = mostViewedMovie.views;
            result.most_viewed_genre = mostViewedMovie.genres;
            
            return result;

        }
    }
}