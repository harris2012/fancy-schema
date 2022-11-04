using System;
using System.Collections.Generic;
using System.Text;

namespace Fancy.Schema
{
    public static partial class SubjectExtension
    {

        #region CreateSubject

        /// <summary>
        /// CreateSubject
        /// </summary>
        public static string CreateSubject(this Subject subject) { return $"Create{subject.Name}"; }

        /// <summary>
        /// CreateSubjectService
        /// </summary>
        public static string CreateSubjectService(this Subject subject) { return $"{subject.CreateSubject()}Service"; }

        /// <summary>
        /// CreateSubjectRequest
        /// </summary>
        public static string CreateSubjectRequest(this Subject subject) { return $"{subject.CreateSubject()}Request"; }

        /// <summary>
        /// CreateSubjectResponse
        /// </summary>
        public static string CreateSubjectResponse(this Subject subject) { return $"{subject.CreateSubject()}Response"; }

        #endregion

        #region FetchSubjectBasic

        /// <summary>
        /// FetchSubjectBasic
        /// </summary>
        public static string FetchSubjectBasic(this Subject subject) { return $"Fetch{subject.Name}Basic"; }

        /// <summary>
        /// FetchSubjectBasicService
        /// </summary>
        public static string FetchSubjectBasicService(this Subject subject) { return $"{subject.FetchSubjectBasic()}Service"; }

        /// <summary>
        /// FetchSubjectBasicRequest
        /// </summary>
        public static string FetchSubjectBasicRequest(this Subject subject) { return $"{subject.FetchSubjectBasic()}Request"; }

        /// <summary>
        /// FetchSubjectBasicResponse
        /// </summary>
        public static string FetchSubjectBasicResponse(this Subject subject) { return $"{subject.FetchSubjectBasic()}Response"; }

        #endregion

        #region FetchSubjectItem

        /// <summary>
        /// FetchSubjectItem
        /// </summary>
        public static string FetchSubjectItem(this Subject subject) { return $"Fetch{subject.Name}Item"; }

        /// <summary>
        /// FetchSubjectItemService
        /// </summary>
        public static string FetchSubjectItemService(this Subject subject) { return $"{subject.FetchSubjectItem()}Service"; }

        /// <summary>
        /// FetchSubjectItemRequest
        /// </summary>
        public static string FetchSubjectItemRequest(this Subject subject) { return $"{subject.FetchSubjectItem()}Request"; }

        /// <summary>
        /// FetchSubjectItemResponse
        /// </summary>
        public static string FetchSubjectItemResponse(this Subject subject) { return $"{subject.FetchSubjectItem()}Response"; }

        #endregion

        #region FetchSubjectList

        /// <summary>
        /// FetchSubjectList
        /// </summary>
        public static string FetchSubjectList(this Subject subject) { return $"Fetch{subject.Name}List"; }

        /// <summary>
        /// FetchSubjectListService
        /// </summary>
        public static string FetchSubjectListService(this Subject subject) { return $"{subject.FetchSubjectList()}Service"; }

        /// <summary>
        /// FetchSubjectListRequest
        /// </summary>
        public static string FetchSubjectListRequest(this Subject subject) { return $"{subject.FetchSubjectList()}Request"; }

        /// <summary>
        /// FetchSubjectListResponse
        /// </summary>
        public static string FetchSubjectListResponse(this Subject subject) { return $"{subject.FetchSubjectList()}Response"; }

        #endregion

        #region UpdateSubject

        /// <summary>
        /// UpdateSubject
        /// </summary>
        public static string UpdateSubject(this Subject subject) { return $"Update{subject.Name}"; }

        /// <summary>
        /// UpdateSubjectService
        /// </summary>
        public static string UpdateSubjectService(this Subject subject) { return $"{subject.UpdateSubject()}Service"; }

        /// <summary>
        /// UpdateSubjectRequest
        /// </summary>
        public static string UpdateSubjectRequest(this Subject subject) { return $"{subject.UpdateSubject()}Request"; }

        /// <summary>
        /// UpdateSubjectResponse
        /// </summary>
        public static string UpdateSubjectResponse(this Subject subject) { return $"{subject.UpdateSubject()}Response"; }

        #endregion

        #region DisableSubject

        /// <summary>
        /// DisableSubject
        /// </summary>
        public static string DisableSubject(this Subject subject) { return $"Disable{subject.Name}"; }

        /// <summary>
        /// DisableSubjectService
        /// </summary>
        public static string DisableSubjectService(this Subject subject) { return $"{subject.DisableSubject()}Service"; }

        /// <summary>
        /// DisableSubjectRequest
        /// </summary>
        public static string DisableSubjectRequest(this Subject subject) { return $"{subject.DisableSubject()}Request"; }

        /// <summary>
        /// DisableSubjectResponse
        /// </summary>
        public static string DisableSubjectResponse(this Subject subject) { return $"{subject.DisableSubject()}Response"; }

        #endregion

        #region EnableSubject

        /// <summary>
        /// EnableSubject
        /// </summary>
        public static string EnableSubject(this Subject subject) { return $"Enable{subject.Name}"; }

        /// <summary>
        /// EnableSubjectService
        /// </summary>
        public static string EnableSubjectService(this Subject subject) { return $"{subject.EnableSubject()}Service"; }

        /// <summary>
        /// EnableSubjectRequest
        /// </summary>
        public static string EnableSubjectRequest(this Subject subject) { return $"{subject.EnableSubject()}Request"; }

        /// <summary>
        /// EnableSubjectResponse
        /// </summary>
        public static string EnableSubjectResponse(this Subject subject) { return $"{subject.EnableSubject()}Response"; }

        #endregion


        /*

        #region {item}

        /// <summary>
        /// {item}
        /// </summary>
        public static string {item}(this Subject subject) { return $"Fetch{subject.Name}List"; }

        /// <summary>
        /// {item}Service
        /// </summary>
        public static string {item}Service(this Subject subject) { return $"{subject.{item}()}Service"; }

        /// <summary>
        /// {item}Request
        /// </summary>
        public static string {item}Request(this Subject subject) { return $"{subject.{item}()}Request"; }

        /// <summary>
        /// {item}Response
        /// </summary>
        public static string {item}Response(this Subject subject) { return $"{subject.{item}()}Response"; }

        #endregion
         */

    }
}
