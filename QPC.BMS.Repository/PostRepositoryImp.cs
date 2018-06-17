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
        public readonly ILoggingHelper logger =
            QPC.BMS.Helpers.DependencyResolution.IoC.Container().GetInstance<ILoggingHelper>(TargetImplement.V1.ToString());


        public bool DeleteAllImages()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllPosts()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllPostTypes()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllRefPostWithTags()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllSeries()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAllTags()
        {
            throw new NotImplementedException();
        }

        public bool DeleteImageByExpression(Func<Image, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteImageByID(Guid imageID)
        {
            throw new NotImplementedException();
        }

        public bool DeletePostByExpression(Func<Post, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeletePostByID(Guid postID)
        {
            throw new NotImplementedException();
        }

        public bool DeletePostTypeByExpression(Func<PostType, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeletePostTypeByID(Guid postTypeID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRefPostWithTagByExpression(Func<RefPostWithTag, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRefPostWithTagByID(Guid refPostWithTagID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSeriesByExpression(Func<Series, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSeriesByID(Guid seriesID)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTagByExpression(Func<Tag, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTagByID(Guid tagID)
        {
            throw new NotImplementedException();
        }

        public bool EditImageByExpression(Func<Image, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditImageByObject(Image modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditPostByExpression(Func<Post, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditPostByObject(Post modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditPostTypeByExpression(Func<PostType, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditPostTypeByObject(PostType modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditRefPostWithTagByExpression(Func<RefPostWithTag, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditRefPostWithTagByObject(RefPostWithTag modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditSeriesByExpression(Func<Series, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditSeriesByObject(Series modelEdit)
        {
            throw new NotImplementedException();
        }

        public bool EditTagByExpression(Func<Tag, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool EditTagByObject(Tag modelEdit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Image> GetAllImages()
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

        public Image GetImageByID(Guid imageID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Image> GetImagesByExpression(Func<Image, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Post GetPostByID(Guid postID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetPostsByExpression(Func<Post, bool> expression)
        {
            throw new NotImplementedException();
        }

        public PostType GetPostTypeByID(Guid postTypeID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostType> GetPostTypesByExpression(Func<PostType, bool> expression)
        {
            throw new NotImplementedException();
        }

        public RefPostWithTag GetRefPostWithTagByID(Guid refPostWithTagID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RefPostWithTag> GetRefPostWithTagsByExpression(Func<RefPostWithTag, bool> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Series> GetSeriesByExpression(Func<Series, bool> expression)
        {
            throw new NotImplementedException();
        }

        public Series GetSeriesByID(Guid seriesID)
        {
            throw new NotImplementedException();
        }

        public Tag GetTagByID(Guid tagID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetTagsByExpression(Func<Tag, bool> expression)
        {
            throw new NotImplementedException();
        }

        public bool SetImage(Image models)
        {
            throw new NotImplementedException();
        }

        public bool SetListImages(List<Image> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListPosts(List<Post> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListPostTypes(List<PostType> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListRefPostWithTags(List<RefPostWithTag> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListSeries(List<Series> models)
        {
            throw new NotImplementedException();
        }

        public bool SetListTags(List<Tag> models)
        {
            throw new NotImplementedException();
        }

        public bool SetPost(Post models)
        {
            throw new NotImplementedException();
        }

        public bool SetPostType(PostType models)
        {
            throw new NotImplementedException();
        }

        public bool SetRefPostWithTag(RefPostWithTag models)
        {
            throw new NotImplementedException();
        }

        public bool SetSeries(Series models)
        {
            throw new NotImplementedException();
        }

        public bool SetTag(Tag models)
        {
            throw new NotImplementedException();
        }
    }
}
