<template>
  <div id="app">
    <div class="header">
      <!-- header -->
      <Header/>
    </div>
    <div class="main mt-2">
      <div class="container-fluid">
        <!-- component content -->
        <router-view/>
      </div>
      
    </div>

    <div class="footer mt-2">
      <!-- footer -->
      <Footer/>
    </div>
  </div>
</template>
<script>
import Header from "./components/Header.vue"
import Footer from "./components/Footer.vue"
export default {
  name: 'App',
  components:{
    Header,
    Footer
  }
}
</script>