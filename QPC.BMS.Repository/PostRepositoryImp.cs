/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository
{
    using System;
    using System.Collections.Generic;
    using QPC.BMS.Helpers;
    using QPC.BMS.Helpers.Enum;
    using QPC.BMS.Repository.EF;

    class PostRepositoryImp : IPostRepository
    {
        /// <summary>
        /// Handle instance for log4net
        /// </summary>
        public readonly ILoggingHelper logger;

        /// <summary>
        /// Handle instance for connect database 
        /// </summary>
        private BMSContext db;

        public PostRepositoryImp()
        {
            logger = Helpers.DependencyResolution.IoC.Container().GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());

            db = new BMSContext();
        }

        public bool DeleteMedia(int imageID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMedia(Func<Media, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMediaType(int imageID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMediaType(Func<MediaType, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeletePost(int postID)
        {
            throw new NotImplementedException();
        }

        public bool DeletePost(Func<Post, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeletePostType(int postTypeID)
        {
            throw new NotImplementedException();
        }

        public bool DeletePostType(Func<PostType, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRefPostWithTag(int refPostWithTagID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRefPostWithTag(Func<RefPostWithTag, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSeries(int seriesID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSeries(Func<Series, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTag(int tagID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTag(Func<Tag, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditMedia(Func<Media, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditMedia(Media modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditMediaType(Func<MediaType, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditMediaType(MediaType modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditPost(Func<Post, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditPost(Post modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditPostType(Func<PostType, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditPostType(PostType modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditRefPostWithTag(Func<RefPostWithTag, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditRefPostWithTag(RefPostWithTag modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditSeries(Func<Series, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditSeries(Series modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditTag(Func<Tag, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditTag(Tag modelEdit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Media> GetAllMedias()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MediaType> GetAllMediaTypes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostType> GetAllPostTypes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RefPostWithTag> GetAllRefPostWithTags()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Series> GetAllSeries()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetAllTags()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Media> GetMedia(Func<Media, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Media GetMedia(int imageID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MediaType> GetMediaType(Func<MediaType, bool> expression)
        {
            throw new NotImplementedException();
        }

        public MediaType GetMediaType(int imageID)
        {
            throw new NotImplementedException();
        }

        public Post GetPost(int postID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetPosts(Func<Post, bool> expression)
        {
            throw new NotImplementedException();
        }

        public PostType GetPostType(int postTypeID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostType> GetPostTypes(Func<PostType, bool> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RefPostWithTag> GetRefPostWithTag(Func<RefPostWithTag, bool> expression)
        {
            throw new NotImplementedException();
        }

        public RefPostWithTag GetRefPostWithTag(int refPostWithTagID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Series> GetSeries(Func<Series, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Series GetSeries(int seriesID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetTag(Func<Tag, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Tag GetTag(int tagID)
        {
            throw new NotImplementedException();
        }

        public bool SetMedia(List<Media> models)
        {
            throw new NotImplementedException();
        }

        public bool SetMedia(Media models)
        {
            throw new NotImplementedException();
        }

        public bool SetMediaType(List<MediaType> models)
        {
            throw new NotImplementedException();
        }

        public bool SetMediaType(MediaType models)
        {
            throw new NotImplementedException();
        }

        public bool SetPost(List<Post> models)
        {
            throw new NotImplementedException();
        }

        public bool SetPost(Post models)
        {
            throw new NotImplementedException();
        }

        public bool SetPostType(List<PostType> models)
        {
            throw new NotImplementedException();
        }

        public bool SetPostType(PostType models)
        {
            throw new NotImplementedException();
        }

        public bool SetRefPostWithTag(List<RefPostWithTag> models)
        {
            throw new NotImplementedException();
        }

        public bool SetRefPostWithTag(RefPostWithTag models)
        {
            throw new NotImplementedException();
        }

        public bool SetSeries(List<Series> models)
        {
            throw new NotImplementedException();
        }

        public bool SetSeries(Series models)
        {
            throw new NotImplementedException();
        }

        public bool SetTag(List<Tag> models)
        {
            throw new NotImplementedException();
        }

        public bool SetTag(Tag models)
        {
            throw new NotImplementedException();
        }
    }
}
