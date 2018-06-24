/// <summary>
/// <company> Nguyen Quy Blogger </company>
/// <author> Nguyen Quy </author>
/// <copyright> Copyright © 2018. All right reserver. </copyright
/// </summary>
namespace QPC.BMS.Repository
{
    using QPC.BMS.Repository.EF;
    using System;
    using System.Collections.Generic;

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
        IEnumerable<Post> GetPosts(Func<Post, bool> expression);

        /// <summary>
        /// Get post by id
        /// </summary>
        /// <param name="postID">post id</param>
        /// <returns>object post</returns>
        Post GetPost(int postID);

        /// <summary>
        /// Insert list post into database
        /// </summary>
        /// <param name="models">list posts</param>
        /// <returns>true or false</returns>
        Boolean SetPost(List<Post> models);

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
        Boolean EditPost(Func<Post, bool> expression);

        /// <summary>
        /// Update post by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditPost(Post modelEdit);

        /// <summary>
        /// Delete post by ID
        /// </summary>
        /// <param name="postID">post id</param>
        /// <returns>true or false</returns>
        Boolean DeletePost(int postID);

        /// <summary>
        /// Delete post by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeletePost(Func<Post, bool> expression);

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
        IEnumerable<Tag> GetTag(Func<Tag, bool> expression);

        /// <summary>
        /// Get tag by id
        /// </summary>
        /// <param name="tagID">tag id</param>
        /// <returns>object tag</returns>
        Tag GetTag(int tagID);

        /// <summary>
        /// Insert list tag into database
        /// </summary>
        /// <param name="models">list tags</param>
        /// <returns>true or false</returns>
        Boolean SetTag(List<Tag> models);

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
        Boolean EditTag(Func<Tag, bool> expression);

        /// <summary>
        /// Update tag by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditTag(Tag modelEdit);

        /// <summary>
        /// Delete tag by ID
        /// </summary>
        /// <param name="tagID">tag id</param>
        /// <returns>true or false</returns>
        Boolean DeleteTag(int tagID);

        /// <summary>
        /// Delete tag by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteTag(Func<Tag, bool> expression);

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
        IEnumerable<Series> GetSeries(Func<Series, bool> expression);

        /// <summary>
        /// Get series by id
        /// </summary>
        /// <param name="seriesID">series id</param>
        /// <returns>object series</returns>
        Series GetSeries(int seriesID);

        /// <summary>
        /// Insert list series into database
        /// </summary>
        /// <param name="models">list series</param>
        /// <returns>true or false</returns>
        Boolean SetSeries(List<Series> models);

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
        Boolean EditSeries(Func<Series, bool> expression);

        /// <summary>
        /// Update series by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditSeries(Series modelEdit);

        /// <summary>
        /// Delete series by ID
        /// </summary>
        /// <param name="seriesID">series id</param>
        /// <returns>true or false</returns>
        Boolean DeleteSeries(int seriesID);

        /// <summary>
        /// Delete series by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteSeries(Func<Series, bool> expression);

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
        IEnumerable<RefPostWithTag> GetRefPostWithTag(Func<RefPostWithTag, bool> expression);

        /// <summary>
        /// Get RefPostWithTag by id
        /// </summary>
        /// <param name="refPostWithTagID">tag id</param>
        /// <returns>object RefPostWithTag</returns>
        RefPostWithTag GetRefPostWithTag(int refPostWithTagID);

        /// <summary>
        /// Insert list RefPostWithTag into database
        /// </summary>
        /// <param name="models">list RefPostWithTags</param>
        /// <returns>true or false</returns>
        Boolean SetRefPostWithTag(List<RefPostWithTag> models);

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
        Boolean EditRefPostWithTag(Func<RefPostWithTag, bool> expression);

        /// <summary>
        /// Update RefPostWithTag by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditRefPostWithTag(RefPostWithTag modelEdit);

        /// <summary>
        /// Delete RefPostWithTag by ID
        /// </summary>
        /// <param name="refPostWithTagID">RefPostWithTag id</param>
        /// <returns>true or false</returns>
        Boolean DeleteRefPostWithTag(int refPostWithTagID);

        /// <summary>
        /// Delete RefPostWithTag by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteRefPostWithTag(Func<RefPostWithTag, bool> expression);

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
        IEnumerable<PostType> GetPostTypes(Func<PostType, bool> expression);

        /// <summary>
        /// Get PostType by id
        /// </summary>
        /// <param name="postTypeID">PostType id</param>
        /// <returns>object PostType</returns>
        PostType GetPostType(int postTypeID);

        /// <summary>
        /// Insert list PostType into database
        /// </summary>
        /// <param name="models">list PostTypes</param>
        /// <returns>true or false</returns>
        Boolean SetPostType(List<PostType> models);

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
        Boolean EditPostType(Func<PostType, bool> expression);

        /// <summary>
        /// Update PostType by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditPostType(PostType modelEdit);

        /// <summary>
        /// Delete PostType by ID
        /// </summary>
        /// <param name="postTypeID">PostType id</param>
        /// <returns>true or false</returns>
        Boolean DeletePostType(int postTypeID);

        /// <summary>
        /// Delete PostType by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeletePostType(Func<PostType, bool> expression);

        #endregion

        #region Table Media

        /// <summary>
        /// Get all Media
        /// </summary>
        /// <returns>list Media</returns>
        IEnumerable<Media> GetAllMedias();

        /// <summary>
        /// Get Media by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list Media</returns>
        IEnumerable<Media> GetMedia(Func<Media, bool> expression);

        /// <summary>
        /// Get Media by id
        /// </summary>
        /// <param name="imageID">Media id</param>
        /// <returns>object Media</returns>
        Media GetMedia(int imageID);

        /// <summary>
        /// Insert list Media into database
        /// </summary>
        /// <param name="models">list Media</param>
        /// <returns>true or false</returns>
        Boolean SetMedia(List<Media> models);

        /// <summary>
        /// Insert object into Media
        /// </summary>
        /// <param name="models">object Media</param>
        /// <returns>true or false</returns>
        Boolean SetMedia(Media models);

        /// <summary>
        /// Update Media by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditMedia(Func<Media, bool> expression);

        /// <summary>
        /// Update Media by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditMedia(Media modelEdit);

        /// <summary>
        /// Delete Media by ID
        /// </summary>
        /// <param name="imageID">Media id</param>
        /// <returns>true or false</returns>
        Boolean DeleteMedia(int imageID);

        /// <summary>
        /// Delete Media by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteMedia(Func<Media, bool> expression);

        #endregion

        #region Table Media Type

        /// <summary>
        /// Get all Media Type
        /// </summary>
        /// <returns>list Media Type</returns>
        IEnumerable<MediaType> GetAllMediaTypes();

        /// <summary>
        /// Get Media Type by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>list Media Type</returns>
        IEnumerable<MediaType> GetMediaType(Func<MediaType, bool> expression);

        /// <summary>
        /// Get Media Type by id
        /// </summary>
        /// <param name="imageID">Media Type id</param>
        /// <returns>object Media Type</returns>
        MediaType GetMediaType(int imageID);

        /// <summary>
        /// Insert list Media Type into database
        /// </summary>
        /// <param name="models">list Media Type</param>
        /// <returns>true or false</returns>
        Boolean SetMediaType(List<MediaType> models);

        /// <summary>
        /// Insert object into Media Type
        /// </summary>
        /// <param name="models">object tagMedia Typeparam>
        /// <returns>true or false</returns>
        Boolean SetMediaType(MediaType models);

        /// <summary>
        /// Update Media Type by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean EditMediaType(Func<MediaType, bool> expression);

        /// <summary>
        /// Update Media Type by object
        /// </summary>
        /// <param name="modelEdit">object edit</param>
        /// <returns>true or false</returns>
        Boolean EditMediaType(MediaType modelEdit);

        /// <summary>
        /// Delete Media Type by ID
        /// </summary>
        /// <param name="imageID">Media Type id</param>
        /// <returns>true or false</returns>
        Boolean DeleteMediaType(int imageID);

        /// <summary>
        /// Delete Media Type by lamdar expression
        /// </summary>
        /// <param name="expression">lamdar expression</param>
        /// <returns>true or false</returns>
        Boolean DeleteMediaType(Func<MediaType, bool> expression);

        #endregion

    }
}
