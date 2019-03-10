# Solve Me First FP
# https://www.hackerrank.com/challenges/fp-solve-me-first/problem

defmodule Solution do
    n1 = IO.gets("") |> String.trim_trailing |> String.to_integer
    n2 = IO.gets("") |> String.to_integer
    IO.puts n1 + n2
end
