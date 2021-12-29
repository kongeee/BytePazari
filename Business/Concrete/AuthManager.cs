using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework {
    public class AuthManager : IAuthService {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper) {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password) {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User {
                Email = userForRegisterDto.Email,
                Name = userForRegisterDto.Name,
                Surname = userForRegisterDto.Surname,
                PhoneNumber = userForRegisterDto.PhoneNumber,
                Password = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, Messages.Smsg);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto) {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null) {
                return new ErrorDataResult<User>(Messages.Emsg_16);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.Password, userToCheck.Data.PasswordSalt)) {
                return new ErrorDataResult<User>(Messages.Emsg_16);
            }

            return new SuccessDataResult<User>(userToCheck.Data, Messages.Smsg);
        }

        public IResult UserExists(string email) {
            if (_userService.GetByMail(email).Data != null) {
                return new ErrorResult(Messages.Emsg_18);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user) {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims.Data);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.Smsg);
        }
    }
}
