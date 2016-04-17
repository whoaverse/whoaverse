﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voat.Data
{
    public static class Selectors
    {
        public static Func<Models.Submission, Models.Submission> SecureSubmission = new Func<Models.Submission, Models.Submission>(x => {
            if (x.IsAnonymized)
            {
                x.UserName = x.ID.ToString();
            }
            if (x.IsDeleted)
            {
                x.UserName = "deleted";
            }
            return x;
        });

        public static Func<Models.Comment, Models.Comment> SecureComment = new Func<Models.Comment, Models.Comment>(x => {
            if (x.IsAnonymized)
            {
                x.UserName = x.ID.ToString();
            }
            if (x.IsDeleted)
            {
                x.UserName = "deleted";
            }
            return x;
        });

        public static Func<Models.usp_CommentTree_Result, Models.usp_CommentTree_Result> SecureCommentTree = new Func<Models.usp_CommentTree_Result, Models.usp_CommentTree_Result>(x => {
            if (x.IsAnonymized)
            {
                x.UserName = x.ID.ToString();
            }
            if (x.IsDeleted)
            {
                x.UserName = "deleted";
            }
            return x;
        });

    }
}