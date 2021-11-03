namespace HackerRank
{
  /*
The member states of the UN are planning to send  people to the Moon. But there is a problem. In line with their principles of global unity, they want to pair astronauts of  different countries.
There are  trained astronauts numbered from  to . But those in charge of the mission did not receive information about the citizenship of each astronaut. The only information they have is that some particular pairs of astronauts belong to the same country.
Your task is to compute in how many ways they can pick a pair of astronauts belonging to different countries. Assume that you are provided enough pairs to let you identify the groups of astronauts even though you might not know their country directly. For instance, if  are astronauts from the same country; it is sufficient to mention that  and  are pairs of astronauts from the same country without providing information about a third pair . 
Input Format
The first line contains two integers,  and , separated by a single space.  lines follow. Each line contains integers separated by a single space  and  such that
and  and  are astronauts from the same country.
Constraints
Output Format
An integer that denotes the number of permissible ways to choose a pair of astronauts.
Sample Input
4 2
0 1
2 3
Sample Output
4
Explanation
Persons numbered  and  belong to same country, and those numbered  and  belong to same country. So the UN can choose one person out of  &  and another person out of  & . So the number of ways of choosing a pair of astronauts is .
*/
using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main1(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        var firstLine = Console.ReadLine().Split(' ');
        var totalPairs = Convert.ToInt64(firstLine[1]);
        var totalAstronauts = Convert.ToInt64(firstLine[0]);
        
        if(totalAstronauts==1) Console.Write(1);
        
        var visited = new bool[totalAstronauts];
        var sets = new List<long>();
        
        var graph = new Dictionary<long, List<long>>();
        
        for(var i=0; i<totalAstronauts; i++) {
            graph.Add(i, new List<long>());
        }
        
        for(var i=0; i<totalPairs; i++) {
            var pair = Console.ReadLine().Split(' ');
            var first = Convert.ToInt64(pair[0]);
            var second = Convert.ToInt64(pair[1]);
            
            if(first >= totalAstronauts || second >= totalAstronauts) return;
            
            graph[first].Add(second);
            graph[second].Add(first);
        }
        
        for(var i=0; i<totalAstronauts; i++) {
            if(visited[i]) continue;
            sets.Add(DFS(i, graph, visited));
        }

        var answer = 0L;
        var sum = 0L;
        foreach(var i in sets) {
            answer += sum*i;
            sum += i;
        }
        
        Console.WriteLine(answer);
    }
    
    static long DFS(long item, Dictionary<long, List<long>> graph, bool[] visited) {
        if(visited[item]) return 0;
        var count = 1L;
        
        visited[item] = true;
        foreach(var i in graph[item]) {
            count+=DFS(i, graph, visited);
        }
        
        return count;
    }
}
}