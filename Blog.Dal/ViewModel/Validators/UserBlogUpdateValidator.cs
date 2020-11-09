using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Dal.ViewModel.Validators
{
    public class UserBlogUpdateValidator : AbstractValidator<UserBlogUpdateDto>
    {
        public UserBlogUpdateValidator()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(64);
            RuleFor(x => x.Summary).NotEmpty().MaximumLength(350);
            RuleFor(x => x.Content).NotEmpty().MaximumLength(3500);
            RuleFor(x => x.PublishedAt).NotEmpty();

        }
    }
}
