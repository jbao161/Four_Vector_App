// JavaScript source code

/**
 *
 * @author jbao
 */


function Matrix(element_array) {
    this.elements = element_array;
}

Matrix.prototype.multiply = function (matrix) {
    var dim1 = this.elements[0].length;
    var dim2 = matrix.elements.length;
    if (dim1 != dim2) {
        return null;
    }
    var m2_elements = matrix.elements;
    var cols = element_array.length;
    var rows = element_array[0].length;
    var result_elements = [];
    var entry;
    var i, j, m;
    for ( i = 0; i < row; i++) {
        result_elements[i] = [];
        for ( j = 0; j < col; j++) {
            entry = 0;
            for (m = 0; m < dim1; m++)
            {
                entry += this.elements[i, m] * m2_elements[m, j];
            }
            result_elements[i][j]  = entry;
        }
    }
    return new Matrix(result_elements);
};

