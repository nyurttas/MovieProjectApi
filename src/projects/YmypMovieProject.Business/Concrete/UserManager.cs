using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.Business.Utilites.Results;
using Core.Entity.Concrete;
using YmypMovieProject.Business.Abstract;
using YmypMovieProject.DataAccess.Repositories.Abstract;
using YmypMovieProject.Entity.Dtos.Users;

namespace YmypMovieProject.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

       

        public UserManager(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public IDataResult<ICollection<UserResponseDto>> GetAll(bool deleted = false)
        {
            var users = _userRepository.GetAll();
            if (users == null )
            {
                return new ErrorDataResult<ICollection<UserResponseDto>>("No users found.");
            }
            var userDtos = _mapper.Map<ICollection<UserResponseDto>>(users);
            return new SuccessDataResult<ICollection<UserResponseDto>>(userDtos, "Users retrieved successfully.");
        }

        public IDataResult<UserResponseDto> GetById(Guid id)
        {
           var user = _userRepository.Get(u => u.Id == id);
            if (user == null)
            {
                return new ErrorDataResult<UserResponseDto>("User not found.");
            }
            var userDto = _mapper.Map<UserResponseDto>(user);
            return new SuccessDataResult<UserResponseDto>(userDto, "User retrieved successfully.");
        }

        public IDataResult<User> GetByMail(string email)
        {
            var user = _userRepository.Get(u => u.Email == email);
            if (user == null)
            {
                return new ErrorDataResult<User>("User not found with the provided email.");
            }
            return new SuccessDataResult<User>(user, "User retrieved successfully by email.");
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
           var claims = _userRepository.GetOperationClaims(user);
            if (claims == null )
            {
                return new ErrorDataResult<List<OperationClaim>>("No claims found for the user.");
            }

            return new SuccessDataResult<List<OperationClaim>>(claims, "Claims retrieved successfully.");
        }

        public IResult Insert(UserForRegisterDto dto)
        {
            var user = _mapper.Map<User>(dto);
            _userRepository.Add(user);
            return new SuccessResult("User registered successfully.");
        }

        public IResult Add(User user)
        { 
            _userRepository.Add(user);
            return new SuccessResult("User added successfully.");

        }

        public IResult Modify(UserUpdateRequestDto dto)
        {
           var user = _mapper.Map<User>(dto);
            _userRepository.Update(user);
            return new SuccessResult("User updated successfully.");
        }

        public IResult Remove(Guid id)
        {
            var user = _userRepository.Get(u=>u.Id == id);
            if (user == null)
            {
                return new ErrorResult("User not found.");
            }
            _userRepository.Delete(user);
            return new SuccessResult("User removed successfully.");


        }
    }
}
