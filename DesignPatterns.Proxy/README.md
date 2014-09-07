Proxy Pattern
=============

A proxy is a class that will first validate the request and if it is valid then it will instantiate the real object and perform the action.

Imagine the cost to create an Universe, you can avoid having to create an Universe if it is not going to be needed anyway.

You can see an example in Assassins Creed, the Blacksmith only sells items later in the game, he makes use of a proxy class to validate the request before actually loading all data: https://www.youtube.com/watch?v=whJi3fhwbW0