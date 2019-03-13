<template>
    <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
        
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarColor01">
            <ul class="navbar-nav mr-auto">
            <li class="nav-item">
                <router-link :to="{ name: 'home'}" class="nav-link">Trang chủ</router-link>
            </li>
            <li class="nav-item">
                <router-link :to="{ name: 'finddocument'}" class="nav-link">Tìm chính chủ</router-link>
            </li>
            <li class="nav-item">
                <router-link :to="{ name: '/abc'}" class="nav-link">Tìm giấy tờ thất lạc</router-link>
            </li>
            <li class="nav-item">
                <router-link :to="{ name: '/search'}" class="nav-link">Xem tin tức</router-link>
            </li>
            </ul>
            <form class="form-inline my-2 my-lg-0">
            <input class="form-control mr-sm-2" type="text" placeholder="Search">
            <button class="btn btn-secondary my-2 my-sm-0" type="submit">Search</button>
            </form>
        </div>
    </nav>
</template>
<script>
export default {
    name: 'Header'
}
</script>

