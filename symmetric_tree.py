def is_same_node(self, l: TreeNode, r: TreeNode) -> bool:
        if l is None and r is None:
            return True
        elif l is None or r is None:
            return False

        if l.val != r.val:
            return False

        return self.is_same_node(l.left, r.right) and \
               self.is_same_node(l.right, r.left)
    
def isSymmetric(self, root: TreeNode) -> bool:
	if root is None:
		return True
        
    return self.is_same_node(root.left, root.right)


print(isSymmetric([1,2,2,3,4,4,3]))