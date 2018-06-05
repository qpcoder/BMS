/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>

namespace QP.BMS.Repository
{
    using QP.BMS.Repository.EF;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPostRepository
    {
        #region Table Post

        /// <summary>
        /// Get all posts
        /// </summary>
        /// <returns>list posts</returns>
        IEnumerable<Post> GetAllPosts();

        /// <summary>
        /// Get post by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list posts</returns>
        IEnumerable<Post> GetPostsByExpression(Func<Post, bool> expression);

        /// <summary>
        /// Get post by id
        /// </summary>
        /// <param name="postID">post id</param>
        /// <returns>object post</returns>
        Post GetPostByID(Guid postID);

        /// <summary>
        /// Insert list post into database
        /// </summary>
        /// <param name="models">list posts</param>
        /// <returns>true or false</returns>
        Boolean SetListPosts(List<Post> models);

        /// <summary>
        /// Insert object into post
        /// </summary>
        /// <param name="models">object post</param>
        /// <returns>true or false</returns>
        Boolean SetPost(Post models);

        /// <summary>
        /// Update post by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditPostByExpression(Func<Post, bool> expression);

        /// <summary>
        /// Update post by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditPostByObject(Post modelEdit);

        /// <summary>
        /// Delete post by ID
        /// </summary>
        /// <param name="postID">post id</param>
        /// <returns>true or false</returns>
        Boolean DeletePostByID(Guid postID);

        /// <summary>
        /// Delete post by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeletePostByExpression(Func<Post, bool> expression);

        /// <summary>
        /// Delete all posts
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllPosts();

        #endregion

        #region Table Tag

        /// <summary>
        /// Get all tags
        /// </summary>
        /// <returns>list tags</returns>
        IEnumerable<Tag> GetAllTags();

        /// <summary>
        /// Get tag by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list tags</returns>
        IEnumerable<Tag> GetTagsByExpression(Func<Tag, bool> expression);

        /// <summary>
        /// Get tag by id
        /// </summary>
        /// <param name="tagID">tag id</param>
        /// <returns>object tag</returns>
        Tag GetTagByID(Guid tagID);

        /// <summary>
        /// Insert list tag into database
        /// </summary>
        /// <param name="models">list tags</param>
        /// <returns>true or false</returns>
        Boolean SetListTags(List<Tag> models);

        /// <summary>
        /// Insert object into tag
        /// </summary>
        /// <param name="models">object tag</param>
        /// <returns>true or false</returns>
        Boolean SetTag(Tag models);

        /// <summary>
        /// Update tag by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditTagByExpression(Func<Tag, bool> expression);

        /// <summary>
        /// Update tag by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditTagByObject(Tag modelEdit);

        /// <summary>
        /// Delete tag by ID
        /// </summary>
        /// <param name="tagID">tag id</param>
        /// <returns>true or false</returns>
        Boolean DeleteTagByID(Guid tagID);

        /// <summary>
        /// Delete tag by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteTagByExpression(Func<Tag, bool> expression);

        /// <summary>
        /// Delete all tags
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllTags();

        #endregion

        #region Table Series

        /// <summary>
        /// Get all series
        /// </summary>
        /// <returns>list series</returns>
        IEnumerable<Series> GetAllSeries();

        /// <summary>
        /// Get series by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list series</returns>
        IEnumerable<Series> GetSeriesByExpression(Func<Series, bool> expression);

        /// <summary>
        /// Get series by id
        /// </summary>
        /// <param name="seriesID">series id</param>
        /// <returns>object series</returns>
        Series GetSeriesByID(Guid seriesID);

        /// <summary>
        /// Insert list series into database
        /// </summary>
        /// <param name="models">list series</param>
        /// <returns>true or false</returns>
        Boolean SetListSeries(List<Series> models);

        /// <summary>
        /// Insert object into series
        /// </summary>
        /// <param name="models">object series</param>
        /// <returns>true or false</returns>
        Boolean SetSeries(Series models);

        /// <summary>
        /// Update series by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditSeriesByExpression(Func<Series, bool> expression);

        /// <summary>
        /// Update series by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditSeriesByObject(Series modelEdit);

        /// <summary>
        /// Delete series by ID
        /// </summary>
        /// <param name="seriesID">series id</param>
        /// <returns>true or false</returns>
        Boolean DeleteSeriesByID(Guid seriesID);

        /// <summary>
        /// Delete series by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteSeriesByExpression(Func<Series, bool> expression);

        /// <summary>
        /// Delete all series
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllSeries();

        #endregion

        #region Table RefPostWithTag

        /// <summary>
        /// Get all RefPostWithTags
        /// </summary>
        /// <returns>list RefPostWithTags</returns>
        IEnumerable<RefPostWithTag> GetAllRefPostWithTags();

        /// <summary>
        /// Get RefPostWithTags by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list tags</returns>
        IEnumerable<RefPostWithTag> GetRefPostWithTagsByExpression(Func<RefPostWithTag, bool> expression);

        /// <summary>
        /// Get RefPostWithTag by id
        /// </summary>
        /// <param name="refPostWithTagID">tag id</param>
        /// <returns>object RefPostWithTag</returns>
        RefPostWithTag GetRefPostWithTagByID(Guid refPostWithTagID);

        /// <summary>
        /// Insert list RefPostWithTag into database
        /// </summary>
        /// <param name="models">list RefPostWithTags</param>
        /// <returns>true or false</returns>
        Boolean SetListRefPostWithTags(List<RefPostWithTag> models);

        /// <summary>
        /// Insert object into RefPostWithTag
        /// </summary>
        /// <param name="models">object RefPostWithTag</param>
        /// <returns>true or false</returns>
        Boolean SetRefPostWithTag(RefPostWithTag models);

        /// <summary>
        /// Update RefPostWithTag by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditRefPostWithTagByExpression(Func<RefPostWithTag, bool> expression);

        /// <summary>
        /// Update RefPostWithTag by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditRefPostWithTagByObject(RefPostWithTag modelEdit);

        /// <summary>
        /// Delete RefPostWithTag by ID
        /// </summary>
        /// <param name="refPostWithTagID">RefPostWithTag id</param>
        /// <returns>true or false</returns>
        Boolean DeleteRefPostWithTagByID(Guid refPostWithTagID);

        /// <summary>
        /// Delete RefPostWithTag by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteRefPostWithTagByExpression(Func<RefPostWithTag, bool> expression);

        /// <summary>
        /// Delete all RefPostWithTags
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllRefPostWithTags();

        #endregion

        #region Table PostType

        /// <summary>
        /// Get all PostTypes
        /// </summary>
        /// <returns>list PostTypes</returns>
        IEnumerable<PostType> GetAllPostTypes();

        /// <summary>
        /// Get PostType by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list PostTypes</returns>
        IEnumerable<PostType> GetPostTypesByExpression(Func<PostType, bool> expression);

        /// <summary>
        /// Get PostType by id
        /// </summary>
        /// <param name="postTypeID">PostType id</param>
        /// <returns>object PostType</returns>
        PostType GetPostTypeByID(Guid postTypeID);

        /// <summary>
        /// Insert list PostType into database
        /// </summary>
        /// <param name="models">list PostTypes</param>
        /// <returns>true or false</returns>
        Boolean SetListPostTypes(List<PostType> models);

        /// <summary>
        /// Insert object into PostType
        /// </summary>
        /// <param name="models">object PostType</param>
        /// <returns>true or false</returns>
        Boolean SetPostType(PostType models);

        /// <summary>
        /// Update PostType by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditPostTypeByExpression(Func<PostType, bool> expression);

        /// <summary>
        /// Update PostType by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditPostTypeByObject(PostType modelEdit);

        /// <summary>
        /// Delete PostType by ID
        /// </summary>
        /// <param name="postTypeID">PostType id</param>
        /// <returns>true or false</returns>
        Boolean DeletePostTypeByID(Guid postTypeID);

        /// <summary>
        /// Delete PostType by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeletePostTypeByExpression(Func<PostType, bool> expression);

        /// <summary>
        /// Delete all PostTypes
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllPostTypes();

        #endregion

        #region Table Image

        /// <summary>
        /// Get all tags
        /// </summary>
        /// <returns>list tags</returns>
        IEnumerable<Image> GetAllImages();

        /// <summary>
        /// Get tag by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list tags</returns>
        IEnumerable<Image> GetImagesByExpression(Func<Image, bool> expression);

        /// <summary>
        /// Get tag by id
        /// </summary>
        /// <param name="imageID">tag id</param>
        /// <returns>object tag</returns>
        Image GetImageByID(Guid imageID);

        /// <summary>
        /// Insert list tag into database
        /// </summary>
        /// <param name="models">list tags</param>
        /// <returns>true or false</returns>
        Boolean SetListImages(List<Image> models);

        /// <summary>
        /// Insert object into tag
        /// </summary>
        /// <param name="models">object tag</param>
        /// <returns>true or false</returns>
        Boolean SetImage(Image models);

        /// <summary>
        /// Update tag by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditImageByExpression(Func<Image, bool> expression);

        /// <summary>
        /// Update tag by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditImageByObject(Image modelEdit);

        /// <summary>
        /// Delete tag by ID
        /// </summary>
        /// <param name="imageID">tag id</param>
        /// <returns>true or false</returns>
        Boolean DeleteImageByID(Guid imageID);

        /// <summary>
        /// Delete tag by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteImageByExpression(Func<Image, bool> expression);

        /// <summary>
        /// Delete all tags
        /// </summary>
        /// <returns>true or false</returns>
        Boolean DeleteAllImages();

        #endregion
    }
}
