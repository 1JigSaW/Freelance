from typing import Dict


class cpgs_annotation(object):

    def __init__(self, table, names):
        self.table = table
        self.names = names
    
    def get_cgps(self, dict):
        genes = []
        indexes = []

        keys = list(dict.keys())

        for i in range(len(self.table)):
            for j in range(len(self.table[i])):
                for k in range(len(keys)):
                    if keys[k] == 'genes_in' and isinstance(dict.get(keys[k]), list):
                        for element in dict.get(keys[k]):
                            if element == self.table[2][j]:
                                genes.append(self.table[0][j])
                                indexes.append(j)
                    if keys[k] == 'genes_in' and dict.get(keys[k]) == self.table[2][j]:
                        genes.append(self.table[0][j])
                        indexes.append(j)
        print(list(set(genes)))
        print(list(set(indexes)))
        

cpgs = cpgs_annotation([['cpg454564', 'cpg123'], ['chr_123321', 'chr_456564'], ['TED123', 'TGP456']], ['cpf', 'cpgpdf'])

cpgs.get_cgps({'genes_in' : ['TGP456', 'TED123']})