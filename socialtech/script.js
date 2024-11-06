$(function () {
    // �{�^���A�j���[�V����
    $('.button-more').on('mouseover', function () {
        $(this).animate({
            opacity: 0.5,
            marginLeft: 20,
        }, 100);
    });
    $('.button-more').on('mouseout', function () {
        $(this).animate({
            opacity: 1.0,
            marginLeft: 0
        }, 100);
    });

    //�J���[�Z��
    $('.carousel').slick({
        autoplay: true,
        dots: true,
        infinite: true,
        autoplaySpeed: 5000,
        arrows: false,
    });

    //���M�{�^���N���b�N���̏���
    $('#submit').on('click', function (event) {
        // form�^�O�ɂ�鑗�M������
        event.preventDefault();

        //���̓`�F�b�N���������ʂ�result�Ɋi�[
        let result = inputCheck();

        //�G���[����ƃ��b�Z�[�W���擾
        let error = result.error;
        let message = result.message;

        //�G���[������������t�H�[���𑗐M����
        if (error == false) {
            //�t�H�[�����M�͎��ۂɂ͍s�킸�A���M�������b�Z�[�W�̂ݕ\������
            alert('���₢���킹�𑗐M���܂����B')
        } else {
            //�G���[���b�Z�[�W��\������
            alert(message);
        }
    });

    //�t�H�[�J�X���O�ꂽ�Ƃ��iblur�j�Ƀt�H�[���̓��̓`�F�b�N������
    $('#name').blur(function () {
        inputCheck();
    });
    $('#furigana').blur(function () {
        inputCheck();
    });
    $('#email').blur(function () {
        inputCheck();
    });
    $('#tel').blur(function () {
        inputCheck();
    });
    $('#message').blur(function () {
        inputCheck();
    });
    $('#agree').click(function () {
        inputCheck();
    });

    //���₢���킹�t�H�[���̓��̓`�F�b�N
    function inputCheck() {
        //�G���[�̃`�F�b�N����
        let result;

        //�G���[���b�Z�[�W�̃e�L�X�g
        let message = '';

        //�G���[���Ȃ����false�A�G���[�������true
        let error = false;

        //���O�̃`�F�b�N
        if ($('#name').val() == '') {
            //�G���[����
            $('#name').css('background-color', '#f79999');
            error = true;
            message += '�����O����͂��Ă��������B\n';
        } else {
            //�G���[�Ȃ�
            $('#name').css('background-color', '#fafafa');
        }

        //�t���K�i�̃`�F�b�N
        if ($('#furigana').val() == '') {
            //�G���[����
            $('#furigana').css('background-color', '#f79999');
            error = true;
            message += '�t���K�i����͂��Ă��������B\n';
        } else {
            //�G���[�Ȃ�
            $('#furigana').css('background-color', '#fafafa');
        }

        //�₢���킹�̃`�F�b�N
        if ($('#message').val() == '') {
            //�G���[����
            $('#message').css('background-color', '#f79999');
            error = true;
            message += '���₢���킹���e����͂��Ă��������B\n';
        } else {
            //�G���[�Ȃ�
            $('#message').css('background-color', '#fafafa');
        }

        //���[���A�h���X�̃`�F�b�N
        if ($('#email').val() == '' || $('#email').val().indexOf('@') == -1 || $('#email').val().indexOf('.') == -1) {
            //�G���[����
            $('#email').css('background-color', '#f79999');
            error = true;
            message += '���[���A�h���X�����L���A�܂��́u@�v�u.�v���܂܂�Ă��܂���B\n';
        } else {
            //�G���[�Ȃ�
            $('#email').css('background-color', '#fafafa');
        }

        //�d�b�ԍ��̃`�F�b�N�i�����͂�OK�A�����͂łȂ��ꍇ��-���K�v�j
        if ($('#tel').val() != '' && $('#tel').val().indexOf('-') == -1) {
            //�G���[����
            $('#tel').css('background-color', '#f79999');
            error = true;
            message += '�d�b�ԍ��Ɂu-�v���܂܂�Ă��܂���B\n';
        } else {
            //�G���[�Ȃ�
            $('#tel').css('background-color', '#fafafa');
        }

        //�l���̃`�F�b�N�{�b�N�X�̃`�F�b�N
        if ($('#agree').prop('checked') == false) {
            error = true;
            message += '�l���̎�舵���ɂ��Ă����ӂ���������ꍇ�́A�`�F�b�N�{�b�N�X�Ƀ`�F�b�N���Ă��������B\n';
        }

        //�G���[�̗L���ő��M�{�^����؂�ւ�
        if (error == true) {
            $('#submit').attr('src', 'images/button-submit.png');
        } else {
            $('#submit').attr('src', 'images/button-submit-blue.png');
        }

        //�I�u�W�F�N�g�ŃG���[����ƃ��b�Z�[�W��Ԃ�
        result = {
            error: error,
            message: message
        }

        //�߂�l�Ƃ��ăG���[�����邩�ǂ�����Ԃ�
        return result;
    }
});