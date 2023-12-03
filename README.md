# B.Atomic
Implements atomic TestAndSet operations.

Implemented as a super-simple wrapper around Interlocked.CompareExchange.

## Examples

	int isRunning = 0;
	if(TestAndSet(ref isRunning, replaceWithValue: 1, testForValue: 0))
	{
		// run
		isRunning = 0;
	}

Also see unit tests for examples.