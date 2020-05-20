function changeState(styles) {
	const dataRegister = document.getElementById('data-register').style = styles.style;
	const firstname = document.getElementById('firstname').style = styles.style;
	const lastname = document.getElementById('lastname').style = styles.style;
	const birthDate = document.getElementById('birth-date').style = styles.style;
	const buttonEdit = document.getElementById('button-edit').style = styles.style;
	const firstnameEdit = document.getElementById('firstname-edit').style = styles.styleEdit;
	const lastnameEdit = document.getElementById('lastname-edit').style = styles.styleEdit;
	const birthDateEdit = document.getElementById('birth-date-edit').style = styles.styleEdit;
	const buttonConfirm = document.getElementById('confirm-container').style = styles.styleEdit;
	const buttonCancel = document.getElementById('button-cancel').style = styles.styleEdit;
}

document.addEventListener('readystatechange', (event) => {
	if (document.readyState === 'interactive') {
		const buttonEdit = document.getElementById('button-edit');
		const buttonConfirm = document.getElementById('button-confirm');
		const buttonCancel = document.getElementById('button-cancel');

		const styles = {
			styleEdit: 'display: none',
			style: 'display: block'
		};
		changeState(styles);

		buttonEdit.addEventListener('click', () => {
			const styles = {
				styleEdit: 'display: block',
				style: 'display: none'
			};
			changeState(styles);
		});
		buttonCancel.addEventListener('click', () => {
			const styles = {
				styleEdit: 'display: none',
				style: 'display: block'
			};
			changeState(styles);
		});
		if (buttonConfirm) {
			buttonConfirm.addEventListener('click', () => {
				console.log('confirm');
			});
		}
	}
})