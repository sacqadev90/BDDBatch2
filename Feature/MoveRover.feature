Feature: Moving the rover

Scenario Outline: Move the rover
	Given Rover is at <x>, <y>
	And rover is pointing towards <direction>
	When rover moves forward
	Then rover should be at <newX>, <newY>
	And rover should be facing <direction>

	Examples: "Positive testcases"
		| x | y | direction | newX | newY |
		| 1 | 2 | N         | 1    | 3    |
		| 1 | 2 | W         | 0    | 2    |
		| 1 | 2 | S         | 1    | 1    |
		| 1 | 2 | E         | 2    | 2    |