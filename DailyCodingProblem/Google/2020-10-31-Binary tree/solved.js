binary_tree = {value: 0,left: {value: 1}, rigth: {value: 0, left: {value: 1, left: {value: 1}, rigth: {value: 1}}, rigth: {value: 0}}};

function solve(binary_tree) {
	if (binary_tree.hasOwnProperty("left") && binary_tree.hasOwnProperty("rigth")) {
		if (binary_tree.left.value === binary_tree.rigth.value) {
			return 1 + solve(binary_tree.left) + solve(binary_tree.rigth);
		};
		return solve(binary_tree.left) + solve(binary_tree.rigth);
	}
	
	return 1;
};

console.log(solve(binary_tree));