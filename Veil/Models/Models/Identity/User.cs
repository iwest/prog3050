﻿/* User.cs
 * Purpose: ASP.NET Identity model/user class
 * 
 * Revision History:
 *      Drew Matheson, 2015.10.08: Created
 */ 

using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Veil.DataModels.Validation;

namespace Veil.DataModels.Models.Identity
{
    /// <summary>
    ///     Model for Veil's the Identity User
    /// </summary>
    /// <br/>
    /// <remarks>
    ///     DO NOT use this class as a model for anything which uses model binding.
    /// <br/>
    ///     Instead, use a view model with only the properties you are allowing users to modify
    /// </remarks>
    public class User : IdentityUser<Guid, GuidIdentityUserLogin, GuidIdentityUserRole, GuidIdentityUserClaim>
    {
        /// <summary>
        ///     Generates a <see cref="ClaimsIdentity"/> representing the user
        /// </summary>
        /// <param name="manager">
        ///     The <see cref="UserManager{TUser, TKey}"/> to use for creating the identity
        /// </param>
        /// <returns>
        ///     A Task which will resolve to the created <see cref="ClaimsIdentity"/>
        /// </returns>
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User, Guid> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity =
                await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom user claims here

            return userIdentity;
        }

        /// <summary>
        ///     The User's Email Address
        /// <br/>
        /// <br/>
        ///     This must be unique in the system.
        /// </summary>
        [Required]
        [EmailAddress]
        public override string Email { get; set; }

        /// <summary>
        ///     The User's new email address before confirming it
        /// <br/>
        /// <br/>
        ///     This must be unique in the system.
        /// </summary>
        [EmailAddress]
        public string NewEmail { get; set; }

        /// <summary>
        ///     The User's Username
        /// <br/>
        /// <br/>
        ///     This must be unique in the system.
        /// </summary>
        [Required]
        [StringLength(maximumLength: 256, ErrorMessageResourceName = nameof(ErrorMessages.StringLength), ErrorMessageResourceType = typeof(ErrorMessages))]
        public override string UserName { get; set; }

        /// <summary>
        ///     The User's Phone Number
        /// </summary>
        [RegularExpression(ValidationRegex.STORED_PHONE)]
        [StringLength(maximumLength: 32, ErrorMessageResourceName = nameof(ErrorMessages.StringLength), ErrorMessageResourceType = typeof(ErrorMessages))]
        public override string PhoneNumber { get; set; }

        /// <summary>
        ///     The User's first name
        /// </summary>
        [Required]
        [StringLength(maximumLength: 64, ErrorMessageResourceName = nameof(ErrorMessages.StringLength), ErrorMessageResourceType = typeof(ErrorMessages))]
        public string FirstName { get; set; }

        /// <summary>
        ///     The User's last name
        /// </summary>
        [Required]
        [StringLength(maximumLength: 64, ErrorMessageResourceName = nameof(ErrorMessages.StringLength), ErrorMessageResourceType = typeof(ErrorMessages))]
        public string LastName { get; set; }

        /// <summary>
        ///     Navigation property for the User's Member information
        /// <br/>
        /// <br/>
        ///     This will be null if the User isn't a Member
        /// </summary>
        [CanBeNull]
        public virtual Member Member { get; set; }

        /// <summary>
        ///     Navigation property for the User's Employee information
        /// <br/>
        /// <br/>
        ///     This will be null if the User isn't an Employee
        /// </summary>
        [CanBeNull]
        public virtual Employee Employee { get; set; }
    }
}