#region license
// Copyright (c) 2007-2010 Mauricio Scheffer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;
using System.Collections.Generic;
using SolrNet.Attributes;

namespace SampleSolrApp.Models {
    public class Product {
        [SolrUniqueKey("courseid")]
        public string CourseId { get; set; }

        [SolrField("coursetitle")]
        public string CourseTitle { get; set; }

        [SolrField("coursetitlesearch")]
        public string CourseTitleSearch { get; set; }

        [SolrField("durationinseconds")]
        public int DurationInSeconds { get; set; }

        [SolrField("releasedate")]
        public DateTime ReleaseDate { get; set; }

        [SolrField("description")]
        public string Description { get; set; }

        [SolrField("assessmentstatus")]
        public string AssessmentStatus { get; set; }

        [SolrField("iscourseretired")]
        public string IsCourseRetired { get; set; }

        [SolrField("inStock")]
        public bool InStock { get; set; }

        [SolrField("tag")]
        public ICollection<string> Tag { get; set; }

        [SolrField("course-author")]
        public ICollection<string> CourseAuthor { get; set; }

 

    }
}