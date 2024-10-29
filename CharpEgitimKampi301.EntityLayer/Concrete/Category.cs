﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharpEgitimKampi301.EntityLayer.Concrete
{
    internal class Category
    {
        public int CategoryId { get; set; }// code first yaklaşımı için birinci anahtar olduğumu belirtmek için sınıfın ismi aynı yazılmalı snuna Id eklenmeli

        public int CategoryName { get; set; }   //prob+tab
                                                // get almak set ayarlamak - Get kategori adı sürekli büyük gelsin -  set kural koymak eger 5 karakterden küçükse birseyler yazsın
        public bool CategoryStatus { get; set; }
    }
}

/*
 Field-Variable-Property

int x--> bir değişken direkt class/sınıf içinde tanımlanırsa Field

int y--> class/snıf içinde tanımlanır ve değişken yapısı sonuna get; set alınca property

int z --> bir değer method içinde tanımlanırsa variable

        
        int x;

        public int y { get;set}

        void test() 
        {
            int z;
        }

 
 */