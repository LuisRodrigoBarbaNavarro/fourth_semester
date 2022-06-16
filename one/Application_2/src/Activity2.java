import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JButton;

import java.awt.Color;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JTextField;
import java.awt.Font;
import java.awt.SystemColor;
import javax.swing.JList;
import javax.swing.AbstractListModel;
import javax.swing.JRadioButton;
import javax.swing.JCheckBox;
import javax.swing.SwingConstants;
import javax.swing.ButtonGroup;
import java.awt.ComponentOrientation;
import javax.swing.ImageIcon;
import java.awt.Cursor;

public class Activity2 {

	private JFrame frmActividad;
	private JTextField textField_1;
	private JTextField textField_2;
	private final ButtonGroup buttonGroup = new ButtonGroup();
	private final ButtonGroup buttonGroup_1 = new ButtonGroup();

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Activity2 window = new Activity2();
					window.frmActividad.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Activity2() {
		initialize();
	}
	
	public boolean verifyIntegrity(String name, String course, String id, String gender, String shift) {
		if (name.equals("") || course.equals("") || id.equals("") || gender.equals("") || shift.equals("")) return true; 
		else return false;
	}
	
	public String selectGender(JRadioButton rdbtnHombre, JRadioButton rdbtnMujer) {
		if (rdbtnHombre.isSelected()) return "Hombre";
		else if (rdbtnMujer.isSelected()) return "Mujer";
		else return "";
	}
	
	public String selectTurn(JCheckBox chckbxMatutino, JCheckBox chckbxVespertino, JCheckBox chckbxNocturno) {
		if (chckbxMatutino.isSelected()) return "Matutino";
		else if (chckbxVespertino.isSelected()) return "Vespertino";
		else if (chckbxNocturno.isSelected()) return "Nocturno";
		else return "";
	}
	
	/**
	 * Initialize the contents of the frame.
	 */
	@SuppressWarnings("unchecked")
	private void initialize() {
		frmActividad = new JFrame();
		frmActividad.setResizable(false);
		frmActividad.setTitle("Actividad 2");
		frmActividad.getContentPane().setBackground(Color.WHITE);
		frmActividad.setBounds(100, 100, 450, 606);
		frmActividad.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frmActividad.getContentPane().setLayout(null);
		
		JLabel lblInstitutoTecnolgicoDe = new JLabel("Instituto Tecnol\u00F3gico de Mexicali");
		lblInstitutoTecnolgicoDe.setForeground(Color.WHITE);
		lblInstitutoTecnolgicoDe.setBackground(Color.WHITE);
		lblInstitutoTecnolgicoDe.setHorizontalAlignment(SwingConstants.CENTER);
		lblInstitutoTecnolgicoDe.setFont(new Font("Arial", Font.BOLD, 16));
		lblInstitutoTecnolgicoDe.setBounds(-5, 11, 439, 23);
		frmActividad.getContentPane().add(lblInstitutoTecnolgicoDe);
		
		JLabel lblNombre = new JLabel("Nombre:");
		lblNombre.setForeground(Color.WHITE);
		lblNombre.setFont(new Font("Arial", Font.BOLD, 18));
		lblNombre.setHorizontalAlignment(SwingConstants.CENTER);
		lblNombre.setBounds(21, 87, 91, 14);
		frmActividad.getContentPane().add(lblNombre);
		
		JLabel lblCarrera = new JLabel("Carrera:");
		lblCarrera.setForeground(Color.WHITE);
		lblCarrera.setFont(new Font("Arial", Font.BOLD, 18));
		lblCarrera.setHorizontalAlignment(SwingConstants.CENTER);
		lblCarrera.setBounds(21, 134, 91, 14);
		frmActividad.getContentPane().add(lblCarrera);
		
		JLabel lblCurp = new JLabel("CURP:");
		lblCurp.setForeground(Color.WHITE);
		lblCurp.setFont(new Font("Arial", Font.BOLD, 18));
		lblCurp.setHorizontalAlignment(SwingConstants.CENTER);
		lblCurp.setBounds(21, 341, 91, 14);
		frmActividad.getContentPane().add(lblCurp);
		
		JList list = new JList();
		list.setCursor(Cursor.getPredefinedCursor(Cursor.HAND_CURSOR));
		list.setForeground(Color.DARK_GRAY);
		list.setComponentOrientation(ComponentOrientation.LEFT_TO_RIGHT);
		list.setFont(new Font("Arial", Font.BOLD, 16));
		list.setBackground(Color.WHITE);
		list.setModel(new AbstractListModel() {
			String[] values = new String[] {"Sistemas", "Qu\u00EDmica", "Industrial", "Electr\u00F3nica", "Gesti\u00F3n", "Mecatr\u00F3nica", "M\u00E9canica", "Contadur\u00EDa"};
			public int getSize() {
				return values.length;
			}
			public Object getElementAt(int index) {
				return values[index];
			}
		});
		
		textField_1 = new JTextField();
		textField_1.setFont(new Font("Arial", Font.PLAIN, 14));
		textField_1.setBounds(128, 78, 291, 35);
		frmActividad.getContentPane().add(textField_1);
		textField_1.setColumns(10);
		//make the button transparent
		textField_1.setOpaque(false);
		textField_1.setBorder(null);
		
		textField_2 = new JTextField();
		textField_2.setFont(new Font("Arial", Font.PLAIN, 14));
		textField_2.setColumns(10);
		textField_2.setBounds(128, 332, 291, 35);
		frmActividad.getContentPane().add(textField_2);
		//make the button transparent
		textField_2.setOpaque(false);
		textField_2.setBorder(null);
		
		JLabel lblGnero = new JLabel("G\u00E9nero:");
		lblGnero.setForeground(Color.WHITE);
		lblGnero.setFont(new Font("Arial", Font.BOLD, 18));
		lblGnero.setBounds(28, 396, 91, 14);
		frmActividad.getContentPane().add(lblGnero);
		
		JRadioButton rdbtnHombre = new JRadioButton("    Hombre");
		rdbtnHombre.setForeground(Color.WHITE);
		rdbtnHombre.setFont(new Font("Arial", Font.BOLD, 14));
		buttonGroup_1.add(rdbtnHombre);
		rdbtnHombre.setBounds(125, 389, 97, 31);
		frmActividad.getContentPane().add(rdbtnHombre);
		//make the button transparent
		rdbtnHombre.setOpaque(false);
		//remove content area
		rdbtnHombre.setContentAreaFilled(false);
		//remove the border
		rdbtnHombre.setBorderPainted(false);

		JRadioButton rdbtnMujer = new JRadioButton("    Mujer");
		rdbtnMujer.setForeground(Color.WHITE);
		rdbtnMujer.setFont(new Font("Arial", Font.BOLD, 14));
		buttonGroup_1.add(rdbtnMujer);
		rdbtnMujer.setBounds(261, 389, 97, 31);
		frmActividad.getContentPane().add(rdbtnMujer);
		//make the button transparent
		rdbtnMujer.setOpaque(false);
		//remove content area
		rdbtnMujer.setContentAreaFilled(false);
		//remove the border
		rdbtnMujer.setBorderPainted(false);
		
		JCheckBox chckbxMatutino = new JCheckBox("Matutino");
		chckbxMatutino.setForeground(Color.DARK_GRAY);
		chckbxMatutino.setFont(new Font("Arial", Font.BOLD, 12));
		buttonGroup.add(chckbxMatutino);
		chckbxMatutino.setBounds(125, 445, 89, 23);
		frmActividad.getContentPane().add(chckbxMatutino);
		//make the button transparent
		chckbxMatutino.setOpaque(false);
	    //remove content area
		chckbxMatutino.setContentAreaFilled(false);
	    //remove the border
		chckbxMatutino.setBorderPainted(false);
		
		JCheckBox chckbxVespertino = new JCheckBox("Vespertino");
		chckbxVespertino.setForeground(Color.DARK_GRAY);
		chckbxVespertino.setFont(new Font("Arial", Font.BOLD, 12));
		buttonGroup.add(chckbxVespertino);
		chckbxVespertino.setBounds(217, 445, 89, 23);
		frmActividad.getContentPane().add(chckbxVespertino);
		//make the button transparent
		chckbxVespertino.setOpaque(false);
		//remove content area
		chckbxVespertino.setContentAreaFilled(false);
		//remove the border
		chckbxVespertino.setBorderPainted(false);
		
		JCheckBox chckbxNocturno = new JCheckBox("Nocturno");
		chckbxNocturno.setForeground(Color.DARK_GRAY);
		chckbxNocturno.setFont(new Font("Arial", Font.BOLD, 12));
		buttonGroup.add(chckbxNocturno);
		chckbxNocturno.setBounds(323, 445, 89, 23);
		frmActividad.getContentPane().add(chckbxNocturno);
		//make the button transparent
		chckbxNocturno.setOpaque(false);
		//remove content area
		chckbxNocturno.setContentAreaFilled(false);
		//remove the border
		chckbxNocturno.setBorderPainted(false);
		
		JLabel lblTurno = new JLabel("Turno:");
		lblTurno.setForeground(Color.WHITE);
		lblTurno.setFont(new Font("Arial", Font.BOLD, 18));
		lblTurno.setBounds(34, 448, 78, 14);
		frmActividad.getContentPane().add(lblTurno);
		
		
		list.setBounds(132, 138, 280, 170);
		frmActividad.getContentPane().add(list);
		
		JButton btnAceptar = new JButton("Aceptar");
		btnAceptar.setEnabled(false);
		btnAceptar.setForeground(Color.DARK_GRAY);
		btnAceptar.setFont(new Font("Arial", Font.BOLD, 16));
		btnAceptar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				String name, course, id, gender = null, shift = null;
				name = textField_1.getText();
				course = (String) list.getSelectedValue();
				id = textField_2.getText();
				gender = selectGender(rdbtnHombre, rdbtnMujer);
				shift = selectTurn(chckbxMatutino, chckbxVespertino, chckbxNocturno);
				
				String message = "Nombre: " + name + "\n" + "Carrera: " + course + "\n" + "CURP: " + id + "\n" + "Género: " + gender + "\n" + "Turno: " + shift;
				
				if (verifyIntegrity(name, course, id, gender, shift) != true) {
					JOptionPane.showMessageDialog(null, message, "Registro", JOptionPane.INFORMATION_MESSAGE);
				} else {
					JOptionPane.showMessageDialog(null, "Rellene todos los campos");
				}
			}
		});
		
		JCheckBox chckbxValidate = new JCheckBox("Acepto las condiciones");
		chckbxValidate.setHorizontalAlignment(SwingConstants.CENTER);
		chckbxValidate.setForeground(Color.WHITE);
		chckbxValidate.setFont(new Font("Arial", Font.BOLD, 12));
		chckbxValidate.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (chckbxValidate.isSelected()) btnAceptar.setEnabled(true);
				else btnAceptar.setEnabled(false);
			}
		});
		//make the button transparent
		chckbxValidate.setOpaque(false);
	    //remove content area
		chckbxValidate.setContentAreaFilled(false);
	    //remove the border
		
		btnAceptar.setBackground(SystemColor.inactiveCaption);
		btnAceptar.setBounds(133, 514, 173, 43);
		frmActividad.getContentPane().add(btnAceptar);
		//make the button transparent
	    btnAceptar.setOpaque(false);
	    //remove content area
	    btnAceptar.setContentAreaFilled(false);
	    //remove the border
	    btnAceptar.setBorderPainted(false);
		chckbxValidate.setBounds(133, 484, 173, 23);
		frmActividad.getContentPane().add(chckbxValidate);
		
		JLabel label = new JLabel("");
		label.setForeground(Color.WHITE);
		label.setIcon(new ImageIcon(Activity2.class.getResource("/image/template_activity_2.png")));
		label.setBounds(-5, -16, 449, 607);
		frmActividad.getContentPane().add(label);
	}
}
