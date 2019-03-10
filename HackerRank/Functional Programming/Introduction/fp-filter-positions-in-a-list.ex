# Filter Positions in a List
# https://www.hackerrank.com/challenges/fp-filter-positions-in-a-list/problem

defmodule Implementation do
    def while(r) do
        n = IO.gets("")
        if n == :eof do
            "exit"
        else
            n = String.trim_trailing(n) |> String.to_integer
            if rem(r,2) > 0 do
                IO.puts n
            end
            while(r + 1)
        end
    end
end

defmodule Solution do
    Implementation.while(0)
end
