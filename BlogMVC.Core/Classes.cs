using System;
using System.Collections.Generic;

namespace BlogMVC.Core
{
        public interface IBlogRepository
        {
            IList<Post> Posts(int pageNo, int pageSize);
            int TotalPosts();
        }
        public class Post
        {
            public virtual int Id
            { get; set; }

            public virtual string Title
            { get; set; }

            public virtual string ShortDescription
            { get; set; }

            public virtual string Description
            { get; set; }

            public virtual string Meta
            { get; set; }

            public virtual string UrlSlug
            { get; set; }

            public virtual bool Published
            { get; set; }

            public virtual DateTime PostedOn
            { get; set; }

            public virtual DateTime? Modified
            { get; set; }

            public virtual Category Category
            { get; set; }

            public virtual IList<Tag> Tags
            { get; set; }
        }

        public class Category
        {
            public virtual int Id
            { get; set; }

            public virtual string Name
            { get; set; }

            public virtual string UrlSlug
            { get; set; }

            public virtual string Description
            { get; set; }

            public virtual IList<Post> Posts
            { get; set; }
        }

        public class Tag
        {
            public virtual int Id
            { get; set; }

            public virtual string Name
            { get; set; }

            public virtual string UrlSlug
            { get; set; }

            public virtual string Description
            { get; set; }

            public virtual IList<Post> Posts
            { get; set; }
        }
        

}
