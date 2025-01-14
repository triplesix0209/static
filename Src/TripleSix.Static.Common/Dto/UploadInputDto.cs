﻿using System.ComponentModel;
using Microsoft.AspNetCore.Http;
using TripleSix.Core.Dto;

namespace TripleSix.Static.Common.Dto
{
    public class UploadInputDto : DataDto
    {
        [DisplayName("danh sách file")]
        public IFormFile[] Files { get; set; }

        [DisplayName("api key")]
        public string Key { get; set; }
    }
}
