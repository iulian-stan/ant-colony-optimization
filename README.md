# Ant Colony Optimization

The purpose of this project is to show the use of **ACO** (**A**nt **C**olony **O**ptimization)
methods in minimizations problems. ACO is applied on problems that can be reduced to finding paths 
through graphs, so this implementation targets directly one of the well known cases - **Travelling
Salesman Problem**. Since **ACO** may not find the optimal solution, alogside it there is a backtrack
algorithm implementation for comparison.

Another swarm intelligence based algorithm can be found here - 
[Particle Swarm Optimization](https://github.com/Iulian-Stan/ParticleSwarmOptimization).

## Solution

By running the application it can be seen that the system places the ants in differenc cities (points), 
each one trying to find a path. Combining the solutions, the application iteratively produces the 
best one (**!** it does not mean that the solution is optimal). 

## Interface 

**ACO** solution

![demo aco](https://raw.githubusercontent.com/Iulian-Stan/AntColonyOptimization/007bc8ab8c6d810cbf6e76083c8fa28b72f6b0fc/demo%20aco.PNG)

**Backtrack** solution

![demo bt](https://raw.githubusercontent.com/Iulian-Stan/AntColonyOptimization/007bc8ab8c6d810cbf6e76083c8fa28b72f6b0fc/demo%20bt.PNG)

There is a graphical representation of the problem on the left side and control panel on the right.

## Graphic
Dots represent cities (green one - the starting city, red - others) and arrows the best found path. 
As mentioned before **ACO** can find a local best, not necessarily the global one.  

## Control
Parameters:
* **Cities** - the number of cities
* **Ants** - ant colony population
* **Delay** - small freeze time amount used in simulation
* **Iterations** - number of iteration the algoritm is run
* **α** - **pheromone** influence factor (how much the chosen path is influenced by pheromones)
* **β** - individual influence factor (how much individual desired affect the chosen path)
* **ρ** - **pheromone** evaporation coefficient

Best found solution and optimal solution in terms of path cost (length) are displayed on the bottom.
