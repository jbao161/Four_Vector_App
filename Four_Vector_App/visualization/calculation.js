matrix_multiply = function  (array1, array2) {
    var dim1 = array1[0].length;
    var dim2 = array2.length;
    if (dim1 != dim2) {
        return null;
    }
    var rows = array1.length;
    window.alert(rows);
    var cols = array2[0].length;
    window.alert(cols);

    var result_elements = new Array[rows];
    var entry;
    var i, j, m;
    for (i = 0; i < rows; i++) {
        result_elements[i] = new Array[cols];
        for (j = 0; j < cols; j++) {
            entry = 0;
            for (m = 0; m < dim1; m++) {
                entry += array1[i, m] * array2[m, j];
            }
            result_elements[i][j] = entry;
        }
    }
    return result_elements;
};

function array_2d(rows, cols){
    var elements = new Array(rows);
    var i, j;
    for (i = 0; i < rows; i++) {
        elements[i] = new Array(cols);
        for (j = 0; j < cols; j++) {
            elements[i][j] = 0;
        }
    }
    return elements;
}
 function calculate_gamma( beta)
{
	if (beta > -1.0 && beta < 1.0)
    {
        return 1.0 / Math.sqrt(1.0 - beta * beta);
	}
	return NaN;
}


function button_boost3d_Click_HTML()
{
    try {
        var beta = parseFloat(document.getElementById("beta").value);
        var gamma = calculate_gamma(beta);
        if (isNaN(gamma)) {
            return;
        }
        document.getElementById("gamma").value = gamma.toString();
        var boostx = parseFloat(boost_x.value);
        var boosty = parseFloat(boost_y.value);
        var boostz = parseFloat(boost_z.value);
        var boost_norm = Math.sqrt(boostx * boostx + boosty * boosty + boostz * boostz);
        var betax = beta / boost_norm * boostx;
        var betay = beta / boost_norm * boosty;
        var betaz = beta / boost_norm * boostz;
        var _beta = { betax, betay, betaz };
        document.getElementById("beta_x").value = betax.toString();
        document.getElementById("beta_y").value = betay.toString();
        document.getElementById("beta_z").value = betaz.toString();
        document.getElementById("boost_n_x").value = (boostx / boost_norm).toString();
        document.getElementById("boost_n_y").value = (boosty / boost_norm).toString();
        document.getElementById("boost_n_z").value = (boostz / boost_norm).toString();

        var lorentz_array = new array_2d(4,4);
        lorentz_array[0, 0] = gamma;
        var i,j;
        for ( i = 1; i < 4; i++)
        {
            lorentz_array[i, 0] = -1.0 * gamma * _beta[i - 1];
            lorentz_array[0, i] = -1.0 * gamma * _beta[i - 1];
        }
        for ( i = 1; i < 4; i++)
        {
            for ( j = 1; j < 4; j++)
            {
                lorentz_array[i, j] = (gamma - 1.0) * _beta[i - 1] * _beta[j - 1] / (beta * beta);
            }
        }
        for ( j = 1; j < 4; j++)
        {
            lorentz_array[j, j] += 1;
        }

        if (document.getElementById("x1").value == "") document.getElementById("x1").value = "0";
        if (document.getElementById("x2").value == "") document.getElementById("x2").value = "0";
        if (document.getElementById("x3").value == "") document.getElementById("x3").value = "0";
        if (document.getElementById("x4").value == "") document.getElementById("x4").value = "0";
        var ct = parseFloat(document.getElementById("x1").value);
        var x = parseFloat(document.getElementById("x2").value);
        var y = parseFloat(document.getElementById("x3").value);
        var z = parseFloat(document.getElementById("x4").value);

        var temp_vector = [ct, x, y, z];
        var position_4vector = [];
        position_4vector.push(temp_vector);

        var new_position = matrix_multiply(lorentz_array,position_4vector);

        document.getElementById("out_x1").value = new_position[0, 0].toString();
        document.getElementById("out_x2").value = new_position[1, 0].toString();
        document.getElementById("out_x3").value = new_position[2, 0].toString();
        document.getElementById("out_x4").value = new_position[3, 0].toString();

        //if (document.getElementById("auto_update").checked) button_updatefourvector_Click(sender, e);
    }
    catch (error) {
        console.error(error);
        // expected output: ReferenceError: nonExistentFunction is not defined
        // Note - error messages will vary depending on browser
    }
}
//function button_updatefourvector_Click()
//{
//	textBox_x0.Text = textBox_rotated_x0.Text;
//	textBox_x1.Text = textBox_rotated_x1.Text;
//	textBox_x2.Text = textBox_rotated_x2.Text;
//	textBox_x3.Text = textBox_rotated_x3.Text;
//}

//function button_rotate_Click()
//{
//	try
//	{
//		var theta = parseFloat(textBox_rotation_angle.Text);
//		if (textBox_rotation_x.Text == "") textBox_rotation_x.Text = "0";
//		if (textBox_rotation_y.Text == "") textBox_rotation_y.Text = "0";
//		if (textBox_rotation_z.Text == "") textBox_rotation_z.Text = "0";

//		var rotation_vectorx = parseFloat(textBox_rotation_x.Text);
//		var rotation_vectory = parseFloat(textBox_rotation_y.Text);
//		var rotation_vectorz = parseFloat(textBox_rotation_z.Text);
//		var rotation_norm = Math.sqrt(rotation_vectorx * rotation_vectorx + rotation_vectory * rotation_vectory + rotation_vectorz * rotation_vectorz);
//		var rotation_norm_x = rotation_vectorx / rotation_norm;
//		var rotation_norm_y = rotation_vectory / rotation_norm;
//		var rotation_norm_z = rotation_vectorz / rotation_norm;
//		var _rotationvector = { rotation_norm_x, rotation_norm_y, rotation_norm_z };
//		textBox_rotation_norm_x.Text = rotation_norm_x.toString();
//		textBox_rotation_norm_y.Text = rotation_norm_y.toString();
//		textBox_rotation_norm_z.Text = rotation_norm_z.toString();

//		var rotation_array = Matrix.Calculate_spacetime_rotationmatrix(theta, _rotationvector);
//		textBox_matrix_1_1.Text = rotation_array[0, 0].toString("0.########");
//		textBox_matrix_1_2.Text = rotation_array[0, 1].toString("0.########");
//		textBox_matrix_1_3.Text = rotation_array[0, 2].toString("0.########");
//		textBox_matrix_1_4.Text = rotation_array[0, 3].toString("0.########");
//		textBox_matrix_2_1.Text = rotation_array[1, 0].toString("0.########");
//		textBox_matrix_2_2.Text = rotation_array[1, 1].toString("0.########");
//		textBox_matrix_2_3.Text = rotation_array[1, 2].toString("0.########");
//		textBox_matrix_2_4.Text = rotation_array[1, 3].toString("0.########");
//		textBox_matrix_3_1.Text = rotation_array[2, 0].toString("0.########");
//		textBox_matrix_3_2.Text = rotation_array[2, 1].toString("0.########");
//		textBox_matrix_3_3.Text = rotation_array[2, 2].toString("0.########");
//		textBox_matrix_3_4.Text = rotation_array[2, 3].toString("0.########");
//		textBox_matrix_4_1.Text = rotation_array[3, 0].toString("0.########");
//		textBox_matrix_4_2.Text = rotation_array[3, 1].toString("0.########");
//		textBox_matrix_4_3.Text = rotation_array[3, 2].toString("0.########");
//		textBox_matrix_4_4.Text = rotation_array[3, 3].toString("0.########");

//		if (textBox_x0.Text == "") textBox_x0.Text = "0";
//		if (textBox_x1.Text == "") textBox_x1.Text = "0";
//		if (textBox_x2.Text == "") textBox_x2.Text = "0";
//		if (textBox_x3.Text == "") textBox_x3.Text = "0";
//		var ct = parseFloat(textBox_x0.Text);
//		var x = parseFloat(textBox_x1.Text);
//		var y = parseFloat(textBox_x2.Text);
//		var z = parseFloat(textBox_x3.Text);

//		var position_4vector = new Matrix(new double[] { ct, x, y, z });
//		var rotation_matrix = new Matrix(rotation_array);

//		var new_position = rotation_matrix.multiply(position_4vector);

//		rotation_matrix.print();
//		textBox_rotated_x0.Text = new_position.array[0, 0].toString();
//		textBox_rotated_x1.Text = new_position.array[1, 0].toString();
//		textBox_rotated_x2.Text = new_position.array[2, 0].toString();
//		textBox_rotated_x3.Text = new_position.array[3, 0].toString();

//		if (checkBox_autoupdate_fourvector.Checked) button_updatefourvector_Click(sender, e);
//	}
//	catch (FormatException)
//	{
//		Console.WriteLine("Error converting inputs to numerical values.");
//	}
//}

//function button_boostrotate_Click(object sender, EventArgs e)
//{
//	var ct = textBox_x0.Text;
//	var x = textBox_x1.Text;
//	var y = textBox_x2.Text;
//	var z = textBox_x3.Text;
//	button_boost3d_Click(sender, e);
//	button_updatefourvector_Click(sender, e); // c# events are synchronous. the values will update at the right time.
//	button_rotate_Click(sender, e);
//	if (checkBox_autoupdate_fourvector.Checked == false)
//	{
//		textBox_x0.Text = ct;
//		textBox_x1.Text = x;
//		textBox_x2.Text = y;
//		textBox_x3.Text = z;
//	}
//}

//function button_rotateboost_Click()
//{
//	var ct = textBox_x0.Text;
//	var x = textBox_x1.Text;
//	var y = textBox_x2.Text;
//	var z = textBox_x3.Text;
//	button_rotate_Click(sender, e);
//	button_updatefourvector_Click(sender, e);
//	button_boost3d_Click(sender, e);
//	if (checkBox_autoupdate_fourvector.Checked == false)
//	{
//		textBox_x0.Text = ct;
//		textBox_x1.Text = x;
//		textBox_x2.Text = y;
//		textBox_x3.Text = z;
//	}
//}


window.addEventListener("load", function () { document.getElementById("Button_boost").addEventListener("click", button_boost3d_Click_HTML); });

//function button_boost3d_Click()
//{
//	try
//	{
//		var beta = parseFloat(textBox_beta3d.Text);
//		var gamma = calculate_gamma(beta);
//		if (double.IsNaN(gamma))
//		{
//			return;
//		}
//		textBox_gamma3d.Text = gamma.toString();
//		var boostx = parseFloat(textBox_boostdirectionx3d.Text);
//		var boosty = parseFloat(textBox_boostdirectiony3d.Text);
//		var boostz = parseFloat(textBox_boostdirectionz3d.Text);
//		var boost_norm = Math.sqrt(boostx * boostx + boosty * boosty + boostz * boostz);
//		var betax = beta / boost_norm * boostx;
//		var betay = beta / boost_norm * boosty;
//		var betaz = beta / boost_norm * boostz;
//		var _beta = { betax, betay, betaz };
//		textBox_betax3d.Text = betax.toString();
//		textBox_betay3d.Text = betay.toString();
//		textBox_betaz3d.Text = betaz.toString();
//		textBox_3dboostnormal_x.Text = (boostx / boost_norm).toString();
//		textBox_3dboostnormal_y.Text = (boosty / boost_norm).toString();
//		textBox_3dboostnormal_z.Text = (boostz / boost_norm).toString();

//		var lorentz_array = new double[4, 4];
//		lorentz_array[0, 0] = gamma;
//		for (int i = 1; i < 4; i++)
//		{
//			lorentz_array[i, 0] = -1.0 * gamma * _beta[i - 1];
//			lorentz_array[0, i] = -1.0 * gamma * _beta[i - 1];
//		}
//		for (int i = 1; i < 4; i++)
//		{
//			for (int j = 1; j < 4; j++)
//			{
//				lorentz_array[i, j] = (gamma - 1.0) * _beta[i - 1] * _beta[j - 1] / (beta * beta);
//			}
//		}
//		for (int j = 1; j < 4; j++)
//		{
//			lorentz_array[j, j] += 1;
//		}
//		var lorentz_matrix = new Matrix(lorentz_array);

//		if (textBox_x0.Text == "") textBox_x0.Text = "0";
//		if (textBox_x1.Text == "") textBox_x1.Text = "0";
//		if (textBox_x2.Text == "") textBox_x2.Text = "0";
//		if (textBox_x3.Text == "") textBox_x3.Text = "0";
//		var ct = parseFloat(textBox_x0.Text);
//		var x = parseFloat(textBox_x1.Text);
//		var y = parseFloat(textBox_x2.Text);
//		var z = parseFloat(textBox_x3.Text);

//		var position_4vector = new Matrix(new double[] { ct, x, y, z });

//		var new_position = lorentz_matrix.multiply(position_4vector);

//		textBox_rotated_x0.Text = new_position.array[0, 0].toString();
//		textBox_rotated_x1.Text = new_position.array[1, 0].toString();
//		textBox_rotated_x2.Text = new_position.array[2, 0].toString();
//		textBox_rotated_x3.Text = new_position.array[3, 0].toString();

//		if (checkBox_autoupdate_fourvector.Checked) button_updatefourvector_Click(sender, e);
//	}
//	catch (FormatException)
//	{
//		Console.WriteLine("Error converting inputs to numerical values.");
//	}
//}