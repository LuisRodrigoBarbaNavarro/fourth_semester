import java.awt.EventQueue;

import javax.swing.JFrame;
import java.awt.SystemColor;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.Color;
import javax.swing.ImageIcon;
import java.awt.Font;
import javax.swing.SwingConstants;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class Activity1 {

	private JFrame frmActividad;
	private JTextField textField_1;
	private JTextField textField_2;
	private JTextField textField_3;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Activity1 window = new Activity1();
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
	public Activity1() {
		initialize();
	}
	
	public boolean verifyIntegrity(String name, String course, String id) {
		if (name.equals("") || course.equals("") || id.equals("")) return true; 
		else return false;
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frmActividad = new JFrame();
		frmActividad.setResizable(false);
		frmActividad.setTitle("Actividad 1");
		frmActividad.getContentPane().setBackground(Color.WHITE);
		frmActividad.getContentPane().setLayout(null);
		
		JLabel lblNombre = new JLabel("Nombre:");
		lblNombre.setHorizontalAlignment(SwingConstants.CENTER);
		lblNombre.setForeground(Color.WHITE);
		lblNombre.setFont(new Font("Arial", Font.BOLD, 16));
		lblNombre.setBounds(10, 113, 95, 14);
		frmActividad.getContentPane().add(lblNombre);
		
		textField_1 = new JTextField();
		textField_1.setFont(new Font("Arial", Font.PLAIN, 14));
		textField_1.setBounds(111, 107, 236, 25);
		frmActividad.getContentPane().add(textField_1);
		textField_1.setColumns(10);
		//make the button transparent
		textField_1.setOpaque(false);
		textField_1.setBorder(null);
		
		
		JLabel lblCarrera = new JLabel("Carrera:");
		lblCarrera.setHorizontalAlignment(SwingConstants.CENTER);
		lblCarrera.setForeground(Color.WHITE);
		lblCarrera.setFont(new Font("Arial", Font.BOLD, 16));
		lblCarrera.setBounds(10, 162, 95, 14);
		frmActividad.getContentPane().add(lblCarrera);
		
		textField_2 = new JTextField();
		textField_2.setFont(new Font("Arial", Font.PLAIN, 14));
		textField_2.setColumns(10);
		textField_2.setBounds(111, 161, 236, 25);
		frmActividad.getContentPane().add(textField_2);
		//make the button transparent
		textField_2.setOpaque(false);
		textField_2.setBorder(null);
		
		textField_3 = new JTextField();
		textField_3.setFont(new Font("Arial", Font.PLAIN, 14));
		textField_3.setColumns(10);
		textField_3.setBounds(111, 216, 236, 25);
		frmActividad.getContentPane().add(textField_3);
		//make the button transparent
		textField_3.setOpaque(false);
		textField_3.setBorder(null);
		
		
		JLabel lblCurp = new JLabel("CURP:");
		lblCurp.setHorizontalAlignment(SwingConstants.CENTER);
		lblCurp.setForeground(Color.WHITE);
		lblCurp.setFont(new Font("Arial", Font.BOLD, 16));
		lblCurp.setBounds(10, 219, 95, 14);
		frmActividad.getContentPane().add(lblCurp);
		
		JLabel lblInstitutoTecnolgicoDe = new JLabel("Instituto Tecnol\u00F3gico de Mexicali");
		lblInstitutoTecnolgicoDe.setHorizontalAlignment(SwingConstants.CENTER);
		lblInstitutoTecnolgicoDe.setFont(new Font("Arial", Font.BOLD, 16));
		lblInstitutoTecnolgicoDe.setForeground(Color.WHITE);
		lblInstitutoTecnolgicoDe.setBounds(0, 11, 369, 24);
		frmActividad.getContentPane().add(lblInstitutoTecnolgicoDe);
		
		JButton btnAceptar = new JButton("Aceptar");
		btnAceptar.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {	
				String id, name, course;
				name = textField_1.getText();
				course = textField_2.getText();
				id = textField_3.getText();
				
				String message = "Nombre: " + name + "\n" + "Carrera: " + course + "\n" + "CURP: " + id;
				
				if (verifyIntegrity(name, course, id) != true) {
					JOptionPane.showMessageDialog(null, message, "Registro", JOptionPane.INFORMATION_MESSAGE);
				} else {
					JOptionPane.showMessageDialog(null, "Rellene todos los campos");
				}

			}
		});
		btnAceptar.setFont(new Font("Arial", Font.BOLD, 16));
		btnAceptar.setBounds(91, 279, 193, 43);
		frmActividad.getContentPane().add(btnAceptar);
		//make the button transparent
	    btnAceptar.setOpaque(false);
	    //remove content area
	    btnAceptar.setContentAreaFilled(false);
	    //remove the border
	    btnAceptar.setBorderPainted(false);
		
		JLabel lblRegistroDeInformacin = new JLabel("Registro de informaci\u00F3n");
		lblRegistroDeInformacin.setHorizontalAlignment(SwingConstants.CENTER);
		lblRegistroDeInformacin.setForeground(Color.WHITE);
		lblRegistroDeInformacin.setBackground(Color.WHITE);
		lblRegistroDeInformacin.setFont(new Font("Arial", Font.BOLD, 16));
		lblRegistroDeInformacin.setBounds(0, 46, 369, 50);
		frmActividad.getContentPane().add(lblRegistroDeInformacin);
		
		JLabel lblNewLabel = new JLabel("");
		lblNewLabel.setIcon(new ImageIcon(Activity1.class.getResource("/image/template_activity_1.png")));
		lblNewLabel.setBounds(0, 0, 369, 346);
		frmActividad.getContentPane().add(lblNewLabel);
		frmActividad.setBounds(100, 100, 375, 375);
		frmActividad.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}
}
