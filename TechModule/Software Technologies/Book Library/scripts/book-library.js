const kinveyBaseUrl = "https://baas.kinvey.com/";
const kinveyAppKey = "kid_S134ImYS";
const kinveyAppSecret = "accc37646aef420db43426e1f406e89d";

function showView(viewName) {
    $('main > section').hide();
    $('#' + viewName).show();
}

function showHideMenuLinks() {
    $('#linkHome').show();
    if (sessionStorage.getItem('authToken') == null){
        $('#linkLogin').show();
        $('#linkRegister').show();
        $('#linkListBooks').hide();
        $('#linkCreateBook').hide();
        $('#linkLogout').hide();
    } else {
        $('#linkLogin').hide();
        $('#linkRegister').hide();
        $('#linkListBooks').show();
        $('#linkCreateBook').show();
        $('#linkLogout').show();
    }
}

function showInfo(message) {
    $('#infoBox').text(message);
    $('#infoBox').show();
    setTimeout(function () {
        $('#infoBox').fadeOut()
    }, 3000);
}

function showError(errorMsg) {
    $('#errorBox').text("Error: " + errorMsg)
    $('#errorBox').show();
}

$(function () {
    showHideMenuLinks();
    showView('viewHome');

    $('#linkHome').click(showHomeView);
    $('#linkLogin').click(showLoginView);
    $('#linkRegister').click(showRegisterView);
    $('#linkListBooks').click(listBooks);
    $('#linkCreateBook').click(showCreateBookView);
    $('#linkLogout').click(logout);

    $('#formLogin').submit(login);
    $('#formRegister').submit(register);
    $('#formCreateBook').submit(createBook);

    $(document).on({
        ajaxStart: function () {
            $('#loadingBox').show()
        },
        ajaxStop: function () {
            $('#loadingBox').hide()
        }
    });
})

function showHomeView() {
    showView('viewHome');
}

function showLoginView() {
    showView('viewLogin');
}

function login() {
    const kinveyLoginUrl = kinveyBaseUrl + "user/" + kinveyAppKey + "/login";
    const kinveyAuthHeaders = {
        'Authorization': "Basic " + btoa(kinveyAppKey + ":" + kinveyAppSecret),
    };
    let userData = {
        username: $('#loginUser').val(),
        password: $('#loginPass').val()
    };
    $.ajax({
        method: "POST",
        url: kinveyLoginUrl,
        headers: kinveyAuthHeaders,
        data: userData,
        success: loginSuccess,
        error: handleAjaxError
    });

    function loginSuccess(response) {
        let userAuth = response._kmd.authtoken;
        sessionStorage.setItem('authToken', userAuth);
        showHideMenuLinks();
        listBooks();
        showInfo('Login Successful.')
    }
}

function showRegisterView() {
    showView('viewRegister')
}

function register() {
    const kinveyRegisterUrl = kinveyBaseUrl + "user/" + kinveyAppKey + "/";
    const kinveyAuthHeaders = {
        'Authorization': "Basic " + btoa(kinveyAppKey + ":" + kinveyAppSecret)
    };
    let userData = {
        username: $('#registerUser').val(),
        password: $('#registerPass').val()
    };
    $.ajax({
        method: "POST",
        url: kinveyRegisterUrl,
        headers: kinveyAuthHeaders,
        data: userData,
        success: registerSuccess,
        error: handleAjaxError
    });

    function registerSuccess(response) {
        let userAuth = response._kmd.authtoken;
        sessionStorage.setItem('authToken', userAuth);
        showHideMenuLinks();
        listBooks();
        showInfo('User registration successful.')
    }
}

function handleAjaxError(response) {
    let errorMsg = JSON.stringify(response);
    if (response.readyState === 0)
        errorMsg = "Cannot connect due to network error";
    if (response.responseJSON && response.responseJSON.description)
        errorMsg = response.responseJSON.description;
    showError(errorMsg);
}

function listBooks() {
    $('#books').empty();
    showView('viewBooks');

    const kinveyBooksUrl = kinveyBaseUrl + "appdata/" + kinveyAppKey + "/books";
    const kinveyAuthHeaders = {
        'Authorization': "Kinvey " + sessionStorage.getItem('authToken')
    };
    $.ajax({
        method: "GET",
        url: kinveyBooksUrl,
        headers: kinveyAuthHeaders,
        success: loadBookSuccess,
        error: handleAjaxError
    });
}

function loadBookSuccess(books) {
    showInfo('Books loaded.');
    if (books.length == 0){
        $('#books').text('No books in the library');
    } else {
        let booksTable = $('<table>')
            .append($('<tr>').append(
                '<th>Title</th>',
                '<th>Author</th>',
                '<th>Decription</th>')
            );
        for (let book of books){
            booksTable.append($('<tr>').append(
                $('<td>').text(book.title),
                $('<td>').text(book.author),
                $('<td>').text(book.description))
            );
        }
        $('#books').append(booksTable);
    }
}

function showCreateBookView() {
    showView('viewCreateBook')
}

function createBook() {
    const kinveyBooksUrl = kinveyBaseUrl + "appdata/" + kinveyAppKey + "/books";
    const kinveyAuthHeaders = {
        'Authorization': "Kinvey " + sessionStorage.getItem('authToken')
    };
    let bookData = {
        title: $('#bookTitle').val(),
        author: $('#bookAuthor').val(),
        description: $('#bookDescription').val()
    };

    $.ajax({
        method: "POST",
        url: kinveyBooksUrl,
        headers: kinveyAuthHeaders,
        data: bookData,
        success: createBookSuccess,
        error: handleAjaxError
    });

    function createBookSuccess(response) {
        listBooks();
        showInfo('Book created.')
    }
}

function logout(response) {
    sessionStorage.clear();
    showHideMenuLinks();
    showHomeView();
    showInfo('Logout Successful.')
}