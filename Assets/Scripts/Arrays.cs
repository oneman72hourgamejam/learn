using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DataStructures
{
    public class ArrayTest1
    {
        private DateTime[] hold1 =
        {
            new DateTime(2021, 1, 1),
            new DateTime(2021, 2, 1),
            new DateTime(2021, 2, 2),
            new DateTime(2021, 3, 2),
        };

        private DateTime[] hold2 =
        {
            new DateTime(2021, 1, 1),
            new DateTime(2021, 2, 1),
            new DateTime(2021, 2, 2),
            new DateTime(2021, 3, 2),
        };

        public void Compare()
        {
            Debug.Log(hold1 == hold2);
            Debug.Log(hold1.SequenceEqual(hold2));
        }
    }

    public class Arrays : MonoBehaviour
    {
        private void Start()
        {
            ArrayTest1 at1 = new ArrayTest1();
            at1.Compare();
        }
    }
}