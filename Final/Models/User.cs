﻿using System;
using System.Collections.Generic;

namespace Final.Models;

public partial class User
{

    public long Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Gender { get; set; }

    public string Birthday { get; set; }

    public long StuPerCode { get; set; }

    public long NationalCode { get; set; }

    public long Phone { get; set; }

    public string Address { get; set; } = null!;

    public DateTime? LastLogin { get; set; }

    public DateTime? PreviousLogin { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public long? DeletedBy { get; set; }

    public DateTime? DeletedTime { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<Block> Blocks { get; set; } = new List<Block>();

    public virtual ICollection<Dormitory> Dormitories { get; set; } = new List<Dormitory>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<RoomAssigment> RoomAssigments { get; set; } = new List<RoomAssigment>();

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();

    public virtual ICollection<StudentAsset> StudentAssets { get; set; } = new List<StudentAsset>();

    public virtual ICollection<SubstituteStudentAsset> SubstituteStudentAssets { get; set; } = new List<SubstituteStudentAsset>();

    public virtual ICollection<TransferRoomAssetHistory> TransferRoomAssetHistories { get; set; } = new List<TransferRoomAssetHistory>();
    public virtual ICollection<Repair> Repairs { get; set; } = new List<Repair>();
    public virtual ICollection<RoomAsset> RoomAssets { get; set; } = new List<RoomAsset>();

    public static User? FindUser(string UserName, string Password)
    {
        DormitoryDbContext db = new DormitoryDbContext();
        return db.Users.Where(i => i.UserName == UserName && i.Password == Password).FirstOrDefault();
    }
    public static User? FindUserByNationalCode(string Stu_Per_Code, string NationalCode)
    {
        DormitoryDbContext db = new DormitoryDbContext();
        return db.Users.Where(i => i.StuPerCode == Convert.ToInt64(Stu_Per_Code) && i.NationalCode == Convert.ToInt64(NationalCode)).FirstOrDefault();
    }
    public static User? FindUserById(long? UserId)
    {
        DormitoryDbContext db = new DormitoryDbContext();
        return db.Users.Where(i => i.Id == UserId).FirstOrDefault();
    }
    public static bool AnyUser(string UserName)
    {
        DormitoryDbContext db = new DormitoryDbContext();
        return db.Users.Any(i => i.UserName == UserName);
    }
    public static void ChangePassword(User user, string Password)
    {
        DormitoryDbContext db = new DormitoryDbContext();
        db.Users.Update(user);
        user.Password = Password;
        db.SaveChanges();
    }
    public static void SetLogin(User user)
    {
        DormitoryDbContext db = new DormitoryDbContext();
        db.Users.Update(user);
        if (user.LastLogin == null)
            user.LastLogin = DateTime.Now;
        else
        {
            user.PreviousLogin = user.LastLogin;
            user.LastLogin = DateTime.Now;
        }
        db.SaveChanges();
    }
    public static string GetFullName(User user)
    {
        return ((user.Gender == 1) ? "آقا" : "خانم") + " " + user.FirstName + " " + user.LastName;
    }
    public static void SetUser(string FirstName, string LastName, 
                               string UserName, string Password, 
                               string Address, long NationalCode,
                               long Stu_Per_Code, long Phone, 
                               string Birthday , bool IsMan)
    {
        DormitoryDbContext db = new DormitoryDbContext();
        User user = new User();
        user.FirstName = FirstName;
        user.LastName = LastName;
        user.UserName = UserName;
        user.Password = Password;
        if (IsMan == false) user.Gender = 0;
        else user.Gender = 1;
        user.Birthday = Birthday;
        user.NationalCode = NationalCode;
        user.StuPerCode = Stu_Per_Code;
        user.Phone = Phone;
        user.Address = Address;
        user.IsActive = true;
        user.IsDeleted = true;
        
        db.Users.Add(user);
        db.SaveChanges();
    }
    public static void EditUser(long UserEditId ,long UserId ,string FirstName, string LastName,
                               string UserName, string Password,
                               string Address, long NationalCode,
                               long Stu_Per_Code, long Phone,
                               string Birthday, bool IsMan)
    {
        DormitoryDbContext db = new DormitoryDbContext();
        User? user = new User();
        user = User.FindUserById(UserEditId);
        user.FirstName = FirstName;
        user.LastName = LastName;
        user.UserName = UserName;
        user.Password = Password;
        if (IsMan == false) user.Gender = 0;
        else user.Gender = 1;
        user.Birthday = Birthday;
        user.NationalCode = NationalCode;
        user.StuPerCode = Stu_Per_Code;
        user.Phone = Phone;
        user.Address = Address;
        user.IsActive = true;
        user.IsDeleted = true;
        user.ModifiedBy = User.FindUserById(UserId).Id;
        user.ModifiedOn = DateTime.Now;

        db.Users.Add(user);
        db.SaveChanges();
    }
}
