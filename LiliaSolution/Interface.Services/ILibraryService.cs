using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Interface.Services
{
    public interface ILibraryService 
    {
        void GetBooks(int userid, params int[] books);
        void ReturnBooks(int userid, params int[] books);
    }
}
