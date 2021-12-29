﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing {
    public class HashingHelper {

        
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt) {
            using (var hmac = new System.Security.Cryptography.HMACSHA512()) {
                passwordSalt = hmac.Key;//salt
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            }
        }

        
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt) {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt)) {

                var ComputedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < ComputedHash.Length; i++) {
                    if (ComputedHash[i] != passwordHash[i]) {
                        return false;
                    }
                }
                return true;
            }


        }
    }
}
