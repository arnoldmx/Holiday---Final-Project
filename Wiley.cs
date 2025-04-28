/*
 ** File Name: Wiley.CS

* Name: Jackson Wiley
* email:  wileyjn@mail.uc.edu
* Assignment Number: Final Project
* Due Date:   4/29/2025
* Course #/Section:   Web Dev with .net 001
* Semester/Year:   Spring 2025
* Brief Description of the assignment:  Create a web page where we all collaborate through git hub 
* and have a button for each of our problems we idependently solve from LeetCode.

* Brief Description of what this module does. This module contains the code that solves my problem with the added arrays from index.asp.cs runs them through this code to determine the least amount of stops you need 
* 
* Citations: https://leetcode.com/problems/bus-routes/description/ , https://chatgpt.com, https://github.com/jwiley21/wileyjn_Assignment10, https://www.w3schools.com/cs/cs_arrays.php
* Anything else that's relevant:
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Holiday___Final_Project
{
   
        
        public static class Wiley
        {
            
            public static int NumBusesToDestination(int[][] routes, int source, int target)
            {
                if (source == target) return 0;

                // stop → list of buses that stop there
                var stopToBuses = new Dictionary<int, List<int>>();
                for (int bus = 0; bus < routes.Length; bus++)
                {
                    foreach (int stop in routes[bus])
                    {
                        if (!stopToBuses.ContainsKey(stop))
                            stopToBuses[stop] = new List<int>();
                        stopToBuses[stop].Add(bus);
                    }
                }

                var visitedStops = new HashSet<int> { source };
                var visitedBuses = new HashSet<int>();
                var q = new Queue<int>();
                q.Enqueue(source);

                int busesTaken = 0;

                while (q.Count > 0)
                {
                    int levelSize = q.Count;
                    busesTaken++;                       

                    for (int i = 0; i < levelSize; i++)
                    {
                        int curStop = q.Dequeue();

                        if (!stopToBuses.TryGetValue(curStop, out var busesHere))
                            continue;

                        foreach (int bus in busesHere)
                        {
                            if (!visitedBuses.Add(bus)) continue;   // already rode this bus

                            foreach (int nextStop in routes[bus])
                            {
                                if (nextStop == target) return busesTaken;
                                if (visitedStops.Add(nextStop))
                                    q.Enqueue(nextStop);
                            }
                        }
                    }
                }
                return -1;
            }
        }
    }

